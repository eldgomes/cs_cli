#!/bin/bash

csc /target:library /out:VehicleLibrary.dll VehicleBase.cs Car.cs Truck.cs
csc /reference:VehicleLibrary.dll /out:MyProgram.exe Program.cs
./MyProgram.exe
