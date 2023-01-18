using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task18.SubTask18._4._2
{
    /// <summary>
    /// Класс работы с видео
    /// </summary>
    public class WorkWithVideo
    {
        YoutubeClient youtubeClient = new YoutubeClient();
        public async Task VideoInformation(string videoUrl)
        {
            var video = await youtubeClient.Videos.GetAsync(videoUrl);
            Console.WriteLine(video.Duration);
            Console.WriteLine(video.Author);
            Console.WriteLine(video.Url);
        }
        public async Task DownloadVideo(string videoUrl)
        {
            var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(videoUrl);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            Console.WriteLine("Началось скачивание видео");
            await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, $" {streamInfo.Container}");
            Console.WriteLine($"Закончилось скачиваться видео, размер видео {streamInfo.Size}");
        }
    }
}

