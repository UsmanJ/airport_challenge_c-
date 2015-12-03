Airport Control System in C#
======================

Synopsis
-----

The task set was to build an air traffic controller as I had done before but this time in C#. The purpose of this controller is to let the planes know whether to land /take off or not. Some conditions had to be met such as:

- Plane can not land when the weather is stormy
- Airport can not allow plane to land if it is full
- Airport can not release plane if it is empty
- Plane can not take off when weather is stormy

Other conditions exist but they are more common sense i.e. plane can't land if it has already landed. The maximum capacity of this airport was set to 80 planes. 


Approach towards solving the challenge
--------------------------------------

This challenge was solved by firstly deciding on how many classes were needed. Two classes and one module was used in this project as it felt like the best option.

The airport control system is fully functional; however if you feel that their are any errors please let me know.


Steps of using the control system
---------------------------------
```
Airport a = new Airport ();
Plane p = new Plane ();
Plane p1 = new Plane ();
Plane p2 = new Plane ();
a.Land ();
p.Land ();
a.Land ();
p1.Land ();
a.Land ();
p2.Land ();
p.isFlying ();
p.isLanded ();
p.TakeOff ();
p.isLanded ();

Console.WriteLine ();

a.ReleasePlane ();
Console.WriteLine (a.planes.Count + " Planes at the airport");
a.ReleasePlane ();
Console.WriteLine (a.planes.Count + " Planes at the airport");
a.ReleasePlane ();
Console.WriteLine (a.planes.Count + " Planes at the airport");
a.ReleasePlane ();
```

Results of the above steps
---------------------------------
```
Plane landing
Plane has landed
Plane landing
Plane has landed
Plane flying = False
Plane is currently landed
Plane has taken off
Plane is currently airbourne

Plane released
2 Planes at the airport
Plane released
1 Planes at the airport
Plane released
0 Planes at the airport
There are no planes on the airfield
```
