using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApplication
{
    public class TaskOperation
    {
        
            public async Task LongRunningTask()
            {
                await Task.Delay(3000); // Simulating long task
            }
        


    }
}
