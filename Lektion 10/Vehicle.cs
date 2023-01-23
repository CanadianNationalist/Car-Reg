using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
{
private string maker;
private string model;
private int year;
private int weight;
public Vehicle(string a, string b, int c, int d)
{
    maker = a;
    model = b;
    year = c;
    weight = d;
}

public string Maker
{
    get {return maker;}
    set {maker = value;}
}
public string Model
{
    get {return model;}
    set {model = value;}
}
public int Year
{
    get {return year;}
    set {year = value;}
}
public int Weight
{
    get {return weight;}
    set {weight = value;}
}
}
}