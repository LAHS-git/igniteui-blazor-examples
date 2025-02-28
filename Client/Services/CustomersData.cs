using System;
using System.Collections.Generic;
public class CustomersDataItem
{
    public string ID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
}

public class CustomersData
    : List<CustomersDataItem>
{
    public CustomersData()
    {
        this.Add(new CustomersDataItem()
        {
            ID = @"ALFKI",
            CompanyName = @"Alfreds Futterkiste",
            ContactName = @"Maria Anders",
            ContactTitle = @"Sales Representative",
            Address = @"Obere Str. 57",
            City = @"Berlin",
            Region = @"East",
            PostalCode = @"12209",
            Country = @"Germany",
            Phone = @"030-0074321",
            Fax = @"030-0076545"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"ANATR",
            CompanyName = @"Ana Trujillo Emparedados y helados",
            ContactName = @"Ana Trujillo",
            ContactTitle = @"Owner",
            Address = @"Avda. de la Constitución 2222",
            City = @"México D.F.",
            Region = @"South",
            PostalCode = @"05021",
            Country = @"Mexico",
            Phone = @"(5) 555-4729",
            Fax = @"(5) 555-3745"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"ANTON",
            CompanyName = @"Antonio Moreno Taquería",
            ContactName = @"Antonio Moreno",
            ContactTitle = @"Owner",
            Address = @"Mataderos 2312",
            City = @"México D.F.",
            Region = @"South",
            PostalCode = @"05023",
            Country = @"Mexico",
            Phone = @"(5) 555-3932",
            Fax = @"(5) 555-3745"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"AROUT",
            CompanyName = @"Around the Horn",
            ContactName = @"Thomas Hardy",
            ContactTitle = @"Sales Representative",
            Address = @"120 Hanover Sq.",
            City = @"London",
            Region = @"East",
            PostalCode = @"WA1 1DP",
            Country = @"UK",
            Phone = @"(171) 555-7788",
            Fax = @"(171) 555-6750"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"BERGS",
            CompanyName = @"Berglunds snabbköp",
            ContactName = @"Christina Berglund",
            ContactTitle = @"Order Administrator",
            Address = @"Berguvsvägen 8",
            City = @"Luleå",
            Region = @"South",
            PostalCode = @"S-958 22",
            Country = @"Sweden",
            Phone = @"0921-12 34 65",
            Fax = @"0921-12 34 67"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"BLAUS",
            CompanyName = @"Blauer See Delikatessen",
            ContactName = @"Hanna Moos",
            ContactTitle = @"Sales Representative",
            Address = @"Forsterstr. 57",
            City = @"Mannheim",
            Region = @"East",
            PostalCode = @"68306",
            Country = @"Germany",
            Phone = @"0621-08460",
            Fax = @"0621-08924"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"BLONP",
            CompanyName = @"Blondesddsl père et fils",
            ContactName = @"Frédérique Citeaux",
            ContactTitle = @"Marketing Manager",
            Address = @"24, place Kléber",
            City = @"Strasbourg",
            Region = @"East",
            PostalCode = @"67000",
            Country = @"France",
            Phone = @"88.60.15.31",
            Fax = @"88.60.15.32"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"BOLID",
            CompanyName = @"Bólido Comidas preparadas",
            ContactName = @"Martín Sommer",
            ContactTitle = @"Owner",
            Address = @"C/ Araquil, 67",
            City = @"Madrid",
            Region = @"East",
            PostalCode = @"28023",
            Country = @"Spain",
            Phone = @"(91) 555 22 82",
            Fax = @"(91) 555 91 99"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"BONAP",
            CompanyName = @"Bon app'",
            ContactName = @"Laurence Lebihan",
            ContactTitle = @"Owner",
            Address = @"12, rue des Bouchers",
            City = @"Marseille",
            Region = @"West",
            PostalCode = @"13008",
            Country = @"France",
            Phone = @"91.24.45.40",
            Fax = @"91.24.45.41"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"BOTTM",
            CompanyName = @"Bottom-Dollar Markets",
            ContactName = @"Elizabeth Lincoln",
            ContactTitle = @"Accounting Manager",
            Address = @"23 Tsawassen Blvd.",
            City = @"Tsawassen",
            Region = @"BC",
            PostalCode = @"T2F 8M4",
            Country = @"Canada",
            Phone = @"(604) 555-4729",
            Fax = @"(604) 555-3745"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"BSBEV",
            CompanyName = @"B's Beverages",
            ContactName = @"Victoria Ashworth",
            ContactTitle = @"Sales Representative",
            Address = @"Fauntleroy Circus",
            City = @"London",
            Region = @"South",
            PostalCode = @"EC2 5NT",
            Country = @"UK",
            Phone = @"(171) 555-1212",
            Fax = @"(5) 555-3745"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"CACTU",
            CompanyName = @"Cactus Comidas para llevar",
            ContactName = @"Patricio Simpson",
            ContactTitle = @"Sales Agent",
            Address = @"Cerrito 333",
            City = @"Buenos Aires",
            Region = @"East",
            PostalCode = @"1010",
            Country = @"Argentina",
            Phone = @"(1) 135-5555",
            Fax = @"(1) 135-4892"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"CENTC",
            CompanyName = @"Centro comercial Moctezuma",
            ContactName = @"Francisco Chang",
            ContactTitle = @"Marketing Manager",
            Address = @"Sierras de Granada 9993",
            City = @"México D.F.",
            Region = @"South",
            PostalCode = @"05022",
            Country = @"Mexico",
            Phone = @"(5) 555-3392",
            Fax = @"(5) 555-7293"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"CHOPS",
            CompanyName = @"Chop-suey Chinese",
            ContactName = @"Yang Wang",
            ContactTitle = @"Owner",
            Address = @"Hauptstr. 29",
            City = @"Bern",
            Region = @"East",
            PostalCode = @"3012",
            Country = @"Switzerland",
            Phone = @"0452-076545",
            Fax = @"(5) 555-3745"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"COMMI",
            CompanyName = @"Comércio Mineiro",
            ContactName = @"Pedro Afonso",
            ContactTitle = @"Sales Associate",
            Address = @"Av. dos Lusíadas, 23",
            City = @"Sao Paulo",
            Region = @"SP",
            PostalCode = @"05432-043",
            Country = @"Brazil",
            Phone = @"(11) 555-7647",
            Fax = @"(5) 555-3745"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"CONSH",
            CompanyName = @"Consolidated Holdings",
            ContactName = @"Elizabeth Brown",
            ContactTitle = @"Sales Representative",
            Address = @"Berkeley Gardens 12 Brewery",
            City = @"London",
            Region = @"South",
            PostalCode = @"WX1 6LT",
            Country = @"UK",
            Phone = @"(171) 555-2282",
            Fax = @"(171) 555-9199"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"DRACD",
            CompanyName = @"Drachenblut Delikatessen",
            ContactName = @"Sven Ottlieb",
            ContactTitle = @"Order Administrator",
            Address = @"Walserweg 21",
            City = @"Aachen",
            Region = @"South",
            PostalCode = @"52066",
            Country = @"Germany",
            Phone = @"0241-039123",
            Fax = @"0241-059428"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"DUMON",
            CompanyName = @"Du monde entier",
            ContactName = @"Janine Labrune",
            ContactTitle = @"Owner",
            Address = @"67, rue des Cinquante Otages",
            City = @"Nantes",
            Region = @"East",
            PostalCode = @"44000",
            Country = @"France",
            Phone = @"40.67.88.88",
            Fax = @"40.67.89.89"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"EASTC",
            CompanyName = @"Eastern Connection",
            ContactName = @"Ann Devon",
            ContactTitle = @"Sales Agent",
            Address = @"35 King George",
            City = @"London",
            Region = @"East",
            PostalCode = @"WX3 6FW",
            Country = @"UK",
            Phone = @"(171) 555-0297",
            Fax = @"(171) 555-3373"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"ERNSH",
            CompanyName = @"Ernst Handel",
            ContactName = @"Roland Mendel",
            ContactTitle = @"Sales Manager",
            Address = @"Kirchgasse 6",
            City = @"Graz",
            Region = @"South",
            PostalCode = @"8010",
            Country = @"Austria",
            Phone = @"7675-3425",
            Fax = @"7675-3426"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"FAMIA",
            CompanyName = @"Familia Arquibaldo",
            ContactName = @"Aria Cruz",
            ContactTitle = @"Marketing Assistant",
            Address = @"Rua Orós, 92",
            City = @"Sao Paulo",
            Region = @"SP",
            PostalCode = @"05442-030",
            Country = @"Brazil",
            Phone = @"(11) 555-9857",
            Fax = @"(5) 555-3745"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"FISSA",
            CompanyName = @"FISSA Fabrica Inter. Salchichas S.A.",
            ContactName = @"Diego Roel",
            ContactTitle = @"Accounting Manager",
            Address = @"C/ Moralzarzal, 86",
            City = @"Madrid",
            Region = @"East",
            PostalCode = @"28034",
            Country = @"Spain",
            Phone = @"(91) 555 94 44",
            Fax = @"(91) 555 55 93"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"FOLIG",
            CompanyName = @"Folies gourmandes",
            ContactName = @"Martine Rancé",
            ContactTitle = @"Assistant Sales Agent",
            Address = @"184, chaussée de Tournai",
            City = @"Lille",
            Region = @"South",
            PostalCode = @"59000",
            Country = @"France",
            Phone = @"20.16.10.16",
            Fax = @"20.16.10.17"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"FOLKO",
            CompanyName = @"Folk och fä HB",
            ContactName = @"Maria Larsson",
            ContactTitle = @"Owner",
            Address = @"Åkergatan 24",
            City = @"Bräcke",
            Region = @"East",
            PostalCode = @"S-844 67",
            Country = @"Sweden",
            Phone = @"0695-34 67 21",
            Fax = @"0695 33-4455"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"FRANK",
            CompanyName = @"Frankenversand",
            ContactName = @"Peter Franken",
            ContactTitle = @"Marketing Manager",
            Address = @"Berliner Platz 43",
            City = @"München",
            Region = @"East",
            PostalCode = @"80805",
            Country = @"Germany",
            Phone = @"089-0877310",
            Fax = @"089-0877451"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"FRANR",
            CompanyName = @"France restauration",
            ContactName = @"Carine Schmitt",
            ContactTitle = @"Marketing Manager",
            Address = @"54, rue Royale",
            City = @"Nantes",
            Region = @"South",
            PostalCode = @"44000",
            Country = @"France",
            Phone = @"40.32.21.21",
            Fax = @"40.32.21.20"
        });
        this.Add(new CustomersDataItem()
        {
            ID = @"FRANS",
            CompanyName = @"Franchi S.p.A.",
            ContactName = @"Paolo Accorti",
            ContactTitle = @"Sales Representative",
            Address = @"Via Monte Bianco 34",
            City = @"Torino",
            Region = @"East",
            PostalCode = @"10100",
            Country = @"Italy",
            Phone = @"011-4988260",
            Fax = @"011-4988261"
        });
    }
}