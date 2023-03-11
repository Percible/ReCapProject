﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        public virtual void OnBefore(IInvocation invocation) { }
        public virtual void OnAfter(IInvocation invocation) { }
        public virtual void OnSuccess(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation, Exception ex) { }
        public bool isSuccess;
        public override void Intercept(IInvocation invocation)
        {
            isSuccess = true;
            OnBefore(invocation);
            try
            {

                invocation.Proceed();

            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation,e);
                throw;

            }

            finally
            {

                if (isSuccess)
                {
                    OnSuccess(invocation);
                }

            }
            OnAfter(invocation);
        }
    }
}
