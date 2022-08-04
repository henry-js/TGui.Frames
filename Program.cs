using Terminal.Gui;
using TGuiFrames;

Application.Init();

var board = new Board("Dashboard");
Application.Top.Add(board);
Application.Run();
