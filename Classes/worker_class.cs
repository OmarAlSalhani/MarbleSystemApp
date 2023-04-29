using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarbleSystemApp
{
    class worker_class
    {
        public static void run(BackgroundWorker worker)
        {
            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }
    }
}
