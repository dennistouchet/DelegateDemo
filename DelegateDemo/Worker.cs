using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Worker
    {
        public Worker() 
        { 
            Work();
        }

        public void Work()
        {
            var mediaInventory = new MediaInventory();
            var recordPlayer = new RecordPlayer();
            var cassettePlayer = new CassettePlayer();

            MediaInventory.TestMedia testRecordDelegate =
                new MediaInventory.TestMedia(recordPlayer.PlayRecord);
            MediaInventory.TestMedia testCassetteDelegate =
                new MediaInventory.TestMedia(cassettePlayer.PlayCassette);

            mediaInventory.TestResult(testRecordDelegate);
            mediaInventory.TestResult(testCassetteDelegate);

        }
    }
}
