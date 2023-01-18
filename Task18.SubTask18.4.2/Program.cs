
using Task18.SubTask18._4._2;
{
    RemoteControl control = new RemoteControl();
    WorkWithVideo workWithVideo = new WorkWithVideo();

    CommandOne commandOne = new CommandOne(workWithVideo);
    CommandTwo commandTwo = new CommandTwo(workWithVideo);

    control.setCommand(0, commandOne);
    control.setCommand(1, commandTwo);
    Console.WriteLine("Введите 0, чтобы получить информацию об видео или 1, чтобы скачать видео");
    int slot = int.Parse(Console.ReadLine());
    if (slot == 0)
    {
        Console.Clear();
        control.buttonWasPressed(0);
    }
    else if (slot == 1)
    {
        control.buttonWasPressed(1);
    }
}
