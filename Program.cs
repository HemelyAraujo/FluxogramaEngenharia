﻿Console.WriteLine("-- Fluxograma de Engenharia --");

Console.WriteLine("O objeto se move? Responda com S/N");
bool estamovendo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.WriteLine("Deveria se mover?");
bool deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

string mensagem;

if (estamovendo)
{
    if (deveria)
    {
       Console.ForegroundColor = ConsoleColor.Magenta;
       mensagem = "Ótimo, está funcionando perfeitamente!";
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        mensagem = "Use a Silver Tape.";
    }
}

else
{
    if (deveria)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        mensagem = "Use o WD-40 de preferência!";
    }

    else
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      mensagem = "Ótimo, está funcionando perfeitamente!";
    }
}

Console.WriteLine("");
Console.WriteLine(mensagem);
Console.WriteLine("");
Console.ResetColor();