# TrashTalkIndex
The trash talk index is a simple model to estimate how much trash someone talks about other people's cars based on the speed of their own car

**NOTE: This is a joke project I wrote while I was procrastinating at the library.**

## Try it
Open the code in .NET fiddle and place your own values under the top two variables.

[Open in .NET Fiddle](https://dotnetfiddle.net/GPYrkn)

## The Model
![TTI Curve](/Images/modelCurve.png)
The model is very simple. It follows 3 main assumptions:
- People with slow cars talk a lot of trash
- People with very fast cars (FBO GTRs, Civics with laptops, etc) lie and say their car is "ehh, kinda fast"
- People with insanely fast cars (CALVO Viper, Built GTRs, etc) can and do talk as much trash as they want. Their cars are insane.

The model calculation is as follows. 
1. A speed index is calculated by determining how close a vehicle is to predefined constants for a value of 1 (Dragy results from a top fuel dragster). This index is an equally split measure of 0-60 time and quarter mile time.
2. The index is then passed into the model equation, which gives your your trash talking index result. (Amount of trash talking)

### Speed Index (Measurement)
**SI = ( Index<sub>0-60</sub> / 2 ) + ( Index<sub>QuarterMile</sub> / 2)**

Index<sub>x</sub> = Time<sub>Reference</sub> / Time<sub>x</sub>

### Trash Talk Model (Estimation of Trash Talk Amount)
-sqrt(1.66x) + 1.3x<sup>7</sup> + 1

[See this model in Desmos](https://www.desmos.com/calculator/i9ceyfjakm)

### Reference Values
Currently, the model uses constants from the Dragy results of a top fuel dragster

0-60: 0.83s
1/4 Mile: 4.73s

## Implementation
An example C# implementation is included in this repository.