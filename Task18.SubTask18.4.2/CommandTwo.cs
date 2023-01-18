using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18.SubTask18._4._2
{
    public class CommandTwo : ICommand
    {
        WorkWithVideo workWithVideo;
        string videoUrl = "https://www.youtube.com/watch?v=H4jokKBClSc";

        public CommandTwo(WorkWithVideo workWithVideo)
        {
            this.workWithVideo = workWithVideo;
        }

        public void execute()
        {
            Task task1 = workWithVideo.DownloadVideo(videoUrl);
            task1.Wait();
        }
    }
}
