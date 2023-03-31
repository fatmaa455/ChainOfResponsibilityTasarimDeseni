using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // zinciri oluşturacak halkalar
            PlayerHandler mp4Player = new ConcreteHandlerMp4();
            PlayerHandler mpgPlayer = new ConcreteHandlerMpg();
            PlayerHandler aviPlayer = new ConcreteHandlerAvi();

            // zincirin halkaları
            mp4Player.sonraki = mpgPlayer;
            mpgPlayer.sonraki = aviPlayer;

            mp4Player.Play("mpg");
            mp4Player.Play("avi");
            mp4Player.Play("mp4");
            mp4Player.Play("swf");
        }
    }
}
