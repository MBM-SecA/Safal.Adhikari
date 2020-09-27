using System;
using System.Collections.Generic;

public class Country
{
    public string Name { get; set;}
    public string Continent { get; set;}
    public double Area { get; set;}
    public long Population { get; set;}
    public DateTime IndependenceDay { get; set;}

    public Country( string n, string c, double a, long p, DateTime i= default)
    {
        Name = n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
    }

    public static List<Country> GetCountries()
    {
        Country c1 = new Country( "Nepal", "Asia", 47653.34, 3456545);
        Country c2 = new Country( "India", "Asia", 4765575, 55837374, DateTime.Parse("1947/3/23"));
        Country c3 = new Country( "Russia", "Europe", 47653.34, 8347377);
        Country c4 = new Country( "USA", "North America", 78453.45, 845747);
        Country c5 = new Country( "China", "Asia", 837483.43, 34456545);
        Country c6 = new Country( "Canada", "North America", 234982.34, 8457454);
        Country c7 = new Country( "Italy", "Europe", 423434.7, 7458345);
        Country c8 = new Country( "Myanmar", "Asia", 86785.45, 83039);
        Country c9 = new Country( "Kenya", "Africa", 85847.45, 8484734);
        Country c10 = new Country( "South Korea", "Asia", 37483.67, 7364343);
        Country c11 = new Country( "Spain", "Europe", 845739.45, 94845);
        Country c12 = new Country( "Uganda", "Africa", 83473.3, 9836462);
        Country c13 = new Country( "Argentina", "South America", 847573.34, 58387263);
        Country c14 = new Country( "Algeria", "Africa", 98594.54, 2945768);
        Country c15 = new Country( "Sudan", "Africa", 934387.56, 383473);
        Country c16 = new Country( "Ukraine", "Europe", 745746, 36462);
        Country c17 = new Country( "Iraq", "Asia", 923892, 88727346);
        Country c18 = new Country( "Afgansithan", "Asia", 76744364, 3526163);
        Country c19 = new Country( "Bhutan", "Asia", 845784.4, 918263, DateTime.Parse("1947/3/23"));
        Country c20 = new Country( "Maldives", "Asia", 586578.34, 3647372);
        Country c21 = new Country( "Brunei", "Asia", 857575.87, 88902, DateTime.Parse("1947/3/23"));
        Country c22 = new Country( "Domonica", "North America", 7346368.3, 3736452);
        Country c23 = new Country( "Germany", "Europe", 874754.4, 98273);
        Country c24 = new Country( "Syria", "Asia", 784785.35, 382746);
        Country c25 = new Country( "Cambodia", "Asia", 745874.3, 1827364);

        
        var countries = new List<Country>() {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25 };

        return countries;
    }
}