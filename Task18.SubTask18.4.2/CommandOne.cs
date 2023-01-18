using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18.SubTask18._4._2
{
    /// <summary>
    /// Реализация команды1
    /// </summary>
    public class CommandOne : ICommand
    {
        WorkWithVideo workWithVideo;
        string videoUrl = "https://www.youtube.com/watch?v=H4jokKBClSc";

        public CommandOne(WorkWithVideo workWithVideo)
        {
            this.workWithVideo = workWithVideo;
        }

        public void execute()
        {
            Task task = workWithVideo.VideoInformation(videoUrl);
            task.Wait();
        }
    }
}