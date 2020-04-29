
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

namespace Keyboard_Tester.Classes
{
    internal class AppSingleInstance : IDisposable
    {
        public bool _hasHandle = false;
        private Mutex _mutex;

        private void InitMutex()
        {
            string appGuid = ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value;
            string mutexId = string.Format("Global\\{{{0}}}", appGuid);
            _mutex = new Mutex(false, mutexId);

            MutexAccessRule allowEveryoneRule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
            MutexSecurity securitySettings = new MutexSecurity();
            securitySettings.AddAccessRule(allowEveryoneRule);
            _mutex.SetAccessControl(securitySettings);
        }

        public AppSingleInstance(int timeOut)
        {
            InitMutex();
            try
            {
                if (timeOut < 0)
                {
                    _hasHandle = _mutex.WaitOne(Timeout.Infinite, false);
                }
                else
                {
                    _hasHandle = _mutex.WaitOne(timeOut, false);
                }

                if (_hasHandle == false)
                {
                    throw new TimeoutException("Timeout waiting for exclusive access on SingleInstance");
                }
            }
            catch (AbandonedMutexException)
            {
                _hasHandle = true;
            }
        }


        public void Dispose()
        {
            if (_mutex != null)
            {
                if (_hasHandle)
                {
                    _mutex.ReleaseMutex();
                }

                _mutex.Close();
            }
        }
    }
}
