using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuvShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        //Kế thừa từ IDis có sẵn, tự tắt đối tượng khi ko dùng đến
        private bool isDisposable;
        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if(!isDisposable && disposing)
            {
                DisposeCore();
            }
            isDisposable = true;
        }
        protected virtual void DisposeCore()
        {

        }
    }
}
