
var n = 100000000;
var r = 0.0;
var plus = true;

for (var i = 1; i <n; i += 2)
{
    var fraction = 1.0 / i;
    r += plus ? fraction : -fraction;
    plus = !plus;
}

Console.WriteLine(r*4);
Console.WriteLine(Math.PI);

