using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadSaveSingleton
{
    class Singleton
    {
        public int Id { get; set; }

        private static Singleton instanse = null;
        private static Lock lockObject = new Lock();

        protected Singleton(int id)
        {
            Id = id;
        }

        public static Singleton GetInstance(int id)
        {
            lockObject.Enter();
            {
                if (instanse == null)
                {
                    instanse = new Singleton(id);
                }
            }
            lockObject.Exit();

            return instanse;
        }
    }
}
