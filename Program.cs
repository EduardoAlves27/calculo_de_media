// CALCULO DA MEDIA

float soma, media;

Console.WriteLine($"Iremos calcular a media das notas de um aluno");
Thread.Sleep(2000);

Console.WriteLine($"Digite a nota 1 do aluno");
float nt1 = float.Parse(Console.ReadLine());
Thread.Sleep(200);

Console.WriteLine($"Digite a nota 2 do aluno");
float nt2 = float.Parse(Console.ReadLine());
Thread.Sleep(200);

Console.WriteLine($"Digite a nota 3 do aluno");
float nt3 = float.Parse(Console.ReadLine());
Thread.Sleep(200);

Console.WriteLine($"Digite a nota 4 do aluno");
float nt4 = float.Parse(Console.ReadLine());
Thread.Sleep(200);

Console.WriteLine($"Digite a nota 5 do aluno");
float nt5 = float.Parse(Console.ReadLine());
Thread.Sleep(200);

soma = (nt1+nt2+nt3+nt4+nt4);

media = soma/5;

Thread.Sleep(2000);
Console.WriteLine($"A media do aluno e {media}");
