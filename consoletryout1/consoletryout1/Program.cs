

//Msgc.SubscribeClass(typeof(try2));
//var v1 = Msgc.Send(123.1234).Result;
double d2;
using (var t2 = new try2())
using(var t3 = new try2())
{
	
	d2 = Msgc.Send(123).Result;
}


GC.Collect();
Console.WriteLine("after");
var v2 = Msgc.Send(123.1234).Result;
var v3 = Msgc.Send("Hi there").Result;


object o1 = typeof(try2);
object o2 = typeof(try1);

if (o1 == o2) Console.WriteLine("here 1");
try1 t1 = new try1();





ServiceCollection col = new ServiceCollection();
col.AddTransient<ITry1Service, Try1Service>();
col.AddTransient<IRunService, RunService>();

var prov=col.BuildServiceProvider();


Factory<IRunService>.Set(() =>
{
	return new RunService();
});
Factory<ITry1Service>.Set(() =>
{
	return new Try2Service();
});

Stopwatch st = new Stopwatch();

st.Start();

for(int i = 0; i < 100000000; i++)
{
	var t = prov.GetService<ITry1Service>();
	t.RunThis(i);
}

st.Stop();
Console.WriteLine("time: " + st.ElapsedMilliseconds);



st.Start();

for (int i = 0; i < 100000000; i++)
{
	ITry1Service t = Factory<ITry1Service>.Get();
	t.RunThis(i);
}

st.Stop();
Console.WriteLine("time: " + st.ElapsedMilliseconds);


