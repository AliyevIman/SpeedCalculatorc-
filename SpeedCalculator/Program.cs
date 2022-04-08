float distance;
float hour, min, sec;
float timeSec;
float mps;
float kph, mph;

Console.Write("Ne qeder yol gedecek(metres)?: ");
distance = Convert.ToSingle(Console.ReadLine());
Console.Write("Ne qeder vaxt serf edecek(hour): ");
hour = Convert.ToSingle(Console.ReadLine());
Console.Write("Ne qeder vaxt serf edecek(minutes): ");
min = Convert.ToSingle(Console.ReadLine());
Console.Write("Ne qeder vaxt serf edecek(seconds): ");
sec = Convert.ToSingle(Console.ReadLine());

timeSec = (hour * 3600) + (min * 60) + sec;
mps = distance / timeSec;
kph = (distance / 1000.0f) / (timeSec / 3600.0f);
mph = kph / 1.609f;

Console.WriteLine("Sizin suretiniz metres/sec is {0}", mps);
Console.WriteLine("Sizin suretiniz km/h is {0}", kph);
Console.WriteLine("Sizin suretiniz miles/h is {0}", mph);