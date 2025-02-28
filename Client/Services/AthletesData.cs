using System;
using System.Collections.Generic;
public class AthletesDataItem
{
    public double Id { get; set; }
    public string Avatar { get; set; }
    public string Position { get; set; }
    public string Name { get; set; }
    public double AthleteNumber { get; set; }
    public double BeatsPerMinute { get; set; }
    public double TopSpeed { get; set; }
    public string Registered { get; set; }
    public double TrackProgress { get; set; }
    public string CountryFlag { get; set; }
    public string CountryName { get; set; }
}

public class AthletesData
    : List<AthletesDataItem>
{
    public AthletesData()
    {
        this.Add(new AthletesDataItem()
        {
            Id = 84,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/12.jpg",
            Position = @"current",
            Name = @"Abel Brun",
            AthleteNumber = 39315,
            BeatsPerMinute = 105,
            TopSpeed = 5.1,
            Registered = @"2017-10-05T05:54:31-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/af.png",
            CountryName = @"Afghanistan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 65,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/60.jpg",
            Position = @"down",
            Name = @"Keira Walker",
            AthleteNumber = 34116,
            BeatsPerMinute = 94,
            TopSpeed = 4.8,
            Registered = @"2017-01-09T05:46:07-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/al.png",
            CountryName = @"Albania"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 197,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/93.jpg",
            Position = @"current",
            Name = @"Brent Lord",
            AthleteNumber = 20943,
            BeatsPerMinute = 92,
            TopSpeed = 4.8,
            Registered = @"2017-01-23T06:14:22-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/dz.png",
            CountryName = @"Algeria"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 66,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/70.jpg",
            Position = @"down",
            Name = @"Moritz Braun",
            AthleteNumber = 48081,
            BeatsPerMinute = 107,
            TopSpeed = 6,
            Registered = @"2017-06-13T12:54:56-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ad.png",
            CountryName = @"Andorra"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 58,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/60.jpg",
            Position = @"down",
            Name = @"Zaina Pomp",
            AthleteNumber = 14109,
            BeatsPerMinute = 90,
            TopSpeed = 5.7,
            Registered = @"2017-09-07T11:17:40-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ao.png",
            CountryName = @"Angola"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 40,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/33.jpg",
            Position = @"down",
            Name = @"Alberto Clark",
            AthleteNumber = 29912,
            BeatsPerMinute = 93,
            TopSpeed = 4.6,
            Registered = @"2017-02-02T03:50:21-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ag.png",
            CountryName = @"Antigua and Barbuda"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 138,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/38.jpg",
            Position = @"current",
            Name = @"Derrick Price",
            AthleteNumber = 19792,
            BeatsPerMinute = 94,
            TopSpeed = 5.6,
            Registered = @"2017-03-19T01:10:55-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ar.png",
            CountryName = @"Argentina"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 6,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/26.jpg",
            Position = @"up",
            Name = @"Mira Campos",
            AthleteNumber = 39222,
            BeatsPerMinute = 95,
            TopSpeed = 5.9,
            Registered = @"2017-01-11T01:41:31-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/am.png",
            CountryName = @"Armenia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 190,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/44.jpg",
            Position = @"current",
            Name = @"Kiara Dubois",
            AthleteNumber = 49964,
            BeatsPerMinute = 97,
            TopSpeed = 5.6,
            Registered = @"2017-09-28T04:37:56-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/au.png",
            CountryName = @"Australia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 168,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/10.jpg",
            Position = @"current",
            Name = @"Calvin Hunt",
            AthleteNumber = 35535,
            BeatsPerMinute = 94,
            TopSpeed = 4.5,
            Registered = @"2017-11-07T09:58:42-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/at.png",
            CountryName = @"Austria"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 105,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/5.jpg",
            Position = @"down",
            Name = @"Samu Hokkanen",
            AthleteNumber = 22469,
            BeatsPerMinute = 106,
            TopSpeed = 5.5,
            Registered = @"2017-06-29T04:58:27-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/az.png",
            CountryName = @"Azerbaijan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 33,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/18.jpg",
            Position = @"up",
            Name = @"Zackary Roy",
            AthleteNumber = 45996,
            BeatsPerMinute = 92,
            TopSpeed = 4.9,
            Registered = @"2017-07-07T03:51:26-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bs.png",
            CountryName = @"Bahamas"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 83,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/10.jpg",
            Position = @"current",
            Name = @"سینا مرادی",
            AthleteNumber = 10809,
            BeatsPerMinute = 105,
            TopSpeed = 5.3,
            Registered = @"2017-04-05T05:27:13-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bh.png",
            CountryName = @"Bahrain"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 121,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/45.jpg",
            Position = @"current",
            Name = @"Maurice Lambert",
            AthleteNumber = 17443,
            BeatsPerMinute = 96,
            TopSpeed = 5.6,
            Registered = @"2017-06-05T08:19:32-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bd.png",
            CountryName = @"Bangladesh"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 111,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/23.jpg",
            Position = @"up",
            Name = @"Connor Green",
            AthleteNumber = 44716,
            BeatsPerMinute = 95,
            TopSpeed = 4.4,
            Registered = @"2017-06-30T11:23:25-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bb.png",
            CountryName = @"Barbados"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 75,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/69.jpg",
            Position = @"current",
            Name = @"Ellen Leppo",
            AthleteNumber = 29286,
            BeatsPerMinute = 97,
            TopSpeed = 5.6,
            Registered = @"2017-08-16T09:46:35-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/by.png",
            CountryName = @"Belarus"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 68,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/23.jpg",
            Position = @"up",
            Name = @"Sandro Carpentier",
            AthleteNumber = 23503,
            BeatsPerMinute = 96,
            TopSpeed = 5.7,
            Registered = @"2017-09-30T01:01:04-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/be.png",
            CountryName = @"Belgium"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 150,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/52.jpg",
            Position = @"up",
            Name = @"Gustav Petersen",
            AthleteNumber = 20984,
            BeatsPerMinute = 107,
            TopSpeed = 4.6,
            Registered = @"2017-01-01T07:40:19-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bz.png",
            CountryName = @"Belize"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 142,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/63.jpg",
            Position = @"current",
            Name = @"Nicoline Thomsen",
            AthleteNumber = 36778,
            BeatsPerMinute = 99,
            TopSpeed = 5.5,
            Registered = @"2017-03-26T10:04:29-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bj.png",
            CountryName = @"Benin"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 19,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/6.jpg",
            Position = @"current",
            Name = @"Sedef Tunçeri",
            AthleteNumber = 48164,
            BeatsPerMinute = 108,
            TopSpeed = 5.6,
            Registered = @"2017-03-29T11:54:15-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bt.png",
            CountryName = @"Bhutan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 202,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/92.jpg",
            Position = @"down",
            Name = @"Ilona Salonen",
            AthleteNumber = 27068,
            BeatsPerMinute = 91,
            TopSpeed = 5.4,
            Registered = @"2017-07-03T06:19:47-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bo.png",
            CountryName = @"Bolivia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 191,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/72.jpg",
            Position = @"up",
            Name = @"Clarisse Rey",
            AthleteNumber = 29795,
            BeatsPerMinute = 98,
            TopSpeed = 4.9,
            Registered = @"2017-06-09T08:07:19-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ba.png",
            CountryName = @"Bosnia and Herzegovina"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 71,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/74.jpg",
            Position = @"down",
            Name = @"Jimmie Mcguinness",
            AthleteNumber = 20729,
            BeatsPerMinute = 90,
            TopSpeed = 4.6,
            Registered = @"2017-10-07T06:08:00-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bw.png",
            CountryName = @"Botswana"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 82,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/55.jpg",
            Position = @"current",
            Name = @"Johann Fischer",
            AthleteNumber = 37212,
            BeatsPerMinute = 98,
            TopSpeed = 5.8,
            Registered = @"2017-09-01T04:39:52-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/br.png",
            CountryName = @"Brazil"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 121,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/31.jpg",
            Position = @"down",
            Name = @"Ivan Ivanov",
            AthleteNumber = 11054,
            BeatsPerMinute = 108,
            TopSpeed = 5.7,
            Registered = @"2017-04-18T08:03:01-03:00",
            TrackProgress = 75,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bg.png",
            CountryName = @"Bulgaria"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 144,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/57.jpg",
            Position = @"down",
            Name = @"Milja Leino",
            AthleteNumber = 33563,
            BeatsPerMinute = 110,
            TopSpeed = 4.1,
            Registered = @"2017-11-01T10:34:07-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bf.png",
            CountryName = @"Burkina Faso"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 71,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/81.jpg",
            Position = @"down",
            Name = @"آراد جعفری",
            AthleteNumber = 34962,
            BeatsPerMinute = 90,
            TopSpeed = 4.8,
            Registered = @"2017-04-22T04:20:39-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/bi.png",
            CountryName = @"Burundi"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 163,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/21.jpg",
            Position = @"up",
            Name = @"Pippa Roberts",
            AthleteNumber = 15588,
            BeatsPerMinute = 105,
            TopSpeed = 4.1,
            Registered = @"2017-02-07T10:23:13-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/kh.png",
            CountryName = @"Cambodia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 122,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/57.jpg",
            Position = @"down",
            Name = @"Jack Jean-baptiste",
            AthleteNumber = 40427,
            BeatsPerMinute = 110,
            TopSpeed = 4.3,
            Registered = @"2017-11-09T08:50:06-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/cm.png",
            CountryName = @"Cameroon"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 199,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/68.jpg",
            Position = @"up",
            Name = @"Lucie Dumont",
            AthleteNumber = 12104,
            BeatsPerMinute = 108,
            TopSpeed = 4,
            Registered = @"2017-01-08T02:13:29-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ca.png",
            CountryName = @"Canada"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 136,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/10.jpg",
            Position = @"down",
            Name = @"Elaine Matthews",
            AthleteNumber = 38574,
            BeatsPerMinute = 110,
            TopSpeed = 5.5,
            Registered = @"2017-01-26T11:50:00-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/cv.png",
            CountryName = @"Cape Verde"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 70,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/14.jpg",
            Position = @"up",
            Name = @"Emily Olsen",
            AthleteNumber = 13887,
            BeatsPerMinute = 110,
            TopSpeed = 4.8,
            Registered = @"2017-10-03T08:01:40-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/cf.png",
            CountryName = @"Central African Republic"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 21,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/73.jpg",
            Position = @"down",
            Name = @"Kuzey Aclan",
            AthleteNumber = 18583,
            BeatsPerMinute = 102,
            TopSpeed = 5.3,
            Registered = @"2017-09-12T09:14:14-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/td.png",
            CountryName = @"Chad"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 86,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/82.jpg",
            Position = @"current",
            Name = @"Eloida Novaes",
            AthleteNumber = 30751,
            BeatsPerMinute = 107,
            TopSpeed = 4.2,
            Registered = @"2017-01-02T01:04:04-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/cl.png",
            CountryName = @"Chile"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 130,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/24.jpg",
            Position = @"down",
            Name = @"آوا احمدی",
            AthleteNumber = 44347,
            BeatsPerMinute = 110,
            TopSpeed = 4.1,
            Registered = @"2017-06-04T09:04:31-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/cn.png",
            CountryName = @"China"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 127,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/52.jpg",
            Position = @"down",
            Name = @"Gerardo Soto",
            AthleteNumber = 22958,
            BeatsPerMinute = 90,
            TopSpeed = 5,
            Registered = @"2017-06-04T12:52:03-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/co.png",
            CountryName = @"Colombia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 125,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/16.jpg",
            Position = @"current",
            Name = @"Altiva Alves",
            AthleteNumber = 31850,
            BeatsPerMinute = 106,
            TopSpeed = 5.1,
            Registered = @"2017-11-09T02:43:54-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/km.png",
            CountryName = @"Comoros"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 38,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/17.jpg",
            Position = @"current",
            Name = @"Charlotte Meyer",
            AthleteNumber = 21442,
            BeatsPerMinute = 110,
            TopSpeed = 4.6,
            Registered = @"2017-10-19T10:38:35-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ck.png",
            CountryName = @"Cook Islands"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 186,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/42.jpg",
            Position = @"up",
            Name = @"Jimmy Bailey",
            AthleteNumber = 38510,
            BeatsPerMinute = 101,
            TopSpeed = 4.7,
            Registered = @"2017-06-30T04:13:42-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/cr.png",
            CountryName = @"Costa Rica"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 108,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/31.jpg",
            Position = @"up",
            Name = @"Noah Bergeron",
            AthleteNumber = 35139,
            BeatsPerMinute = 110,
            TopSpeed = 5.6,
            Registered = @"2017-06-23T01:21:21-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ci.png",
            CountryName = @"Cote DIvoire"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 176,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/35.jpg",
            Position = @"down",
            Name = @"Laudelino Castro",
            AthleteNumber = 12711,
            BeatsPerMinute = 106,
            TopSpeed = 4.4,
            Registered = @"2017-02-08T04:03:22-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/hr.png",
            CountryName = @"Croatia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 138,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/78.jpg",
            Position = @"current",
            Name = @"Oscar Calvo",
            AthleteNumber = 45078,
            BeatsPerMinute = 109,
            TopSpeed = 4.3,
            Registered = @"2017-06-19T10:57:42-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/cu.png",
            CountryName = @"Cuba"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 137,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/80.jpg",
            Position = @"down",
            Name = @"Lance Dunn",
            AthleteNumber = 10113,
            BeatsPerMinute = 94,
            TopSpeed = 4.5,
            Registered = @"2017-03-13T10:51:36-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/cy.png",
            CountryName = @"Cyprus"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 173,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/18.jpg",
            Position = @"current",
            Name = @"Hassana Camp",
            AthleteNumber = 14467,
            BeatsPerMinute = 104,
            TopSpeed = 5.2,
            Registered = @"2017-06-02T12:21:59-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/cz.png",
            CountryName = @"Czech Republic"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 46,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/55.jpg",
            Position = @"current",
            Name = @"Ronja Kraft",
            AthleteNumber = 21800,
            BeatsPerMinute = 101,
            TopSpeed = 5.3,
            Registered = @"2017-04-02T03:33:57-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/dk.png",
            CountryName = @"Denmark"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 8,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/14.jpg",
            Position = @"up",
            Name = @"Hans Möller",
            AthleteNumber = 34122,
            BeatsPerMinute = 109,
            TopSpeed = 5.6,
            Registered = @"2017-06-20T06:02:49-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/dj.png",
            CountryName = @"Djibouti"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 188,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/45.jpg",
            Position = @"down",
            Name = @"Ceylan Duygulu",
            AthleteNumber = 21527,
            BeatsPerMinute = 99,
            TopSpeed = 4.9,
            Registered = @"2017-07-13T09:06:04-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/dm.png",
            CountryName = @"Dominica"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 134,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/66.jpg",
            Position = @"down",
            Name = @"Anni Waisanen",
            AthleteNumber = 32133,
            BeatsPerMinute = 99,
            TopSpeed = 5,
            Registered = @"2017-08-17T01:35:09-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/do.png",
            CountryName = @"Dominican Republic"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 112,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/53.jpg",
            Position = @"down",
            Name = @"Karen Shaw",
            AthleteNumber = 31048,
            BeatsPerMinute = 107,
            TopSpeed = 5.7,
            Registered = @"2017-05-15T09:25:03-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ec.png",
            CountryName = @"Ecuador"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 161,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/38.jpg",
            Position = @"current",
            Name = @"Alex Martin",
            AthleteNumber = 27887,
            BeatsPerMinute = 96,
            TopSpeed = 4.2,
            Registered = @"2017-10-28T04:06:33-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/eg.png",
            CountryName = @"Egypt"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 196,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/30.jpg",
            Position = @"up",
            Name = @"Begüm Erkekli",
            AthleteNumber = 37888,
            BeatsPerMinute = 104,
            TopSpeed = 4.6,
            Registered = @"2017-10-04T03:02:35-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sv.png",
            CountryName = @"El Salvador"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 24,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/0.jpg",
            Position = @"down",
            Name = @"Joan Ortega",
            AthleteNumber = 49478,
            BeatsPerMinute = 103,
            TopSpeed = 5.4,
            Registered = @"2017-07-04T03:01:47-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gq.png",
            CountryName = @"Equatorial Guinea"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 174,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/29.jpg",
            Position = @"current",
            Name = @"Beatriz Gallardo",
            AthleteNumber = 38538,
            BeatsPerMinute = 101,
            TopSpeed = 6,
            Registered = @"2017-11-06T02:14:31-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/er.png",
            CountryName = @"Eritrea"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 193,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/59.jpg",
            Position = @"down",
            Name = @"Sophia Carlson",
            AthleteNumber = 44183,
            BeatsPerMinute = 102,
            TopSpeed = 5.1,
            Registered = @"2017-09-04T07:03:19-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ee.png",
            CountryName = @"Estonia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 85,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/43.jpg",
            Position = @"down",
            Name = @"Niilo Laurila",
            AthleteNumber = 49215,
            BeatsPerMinute = 104,
            TopSpeed = 4.5,
            Registered = @"2017-04-26T01:26:36-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/et.png",
            CountryName = @"Ethiopia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 201,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/92.jpg",
            Position = @"up",
            Name = @"Kaya Tekand",
            AthleteNumber = 11028,
            BeatsPerMinute = 93,
            TopSpeed = 5.2,
            Registered = @"2017-04-10T09:57:13-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/fj.png",
            CountryName = @"Fiji"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 123,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/31.jpg",
            Position = @"current",
            Name = @"Eeli Makinen",
            AthleteNumber = 45296,
            BeatsPerMinute = 106,
            TopSpeed = 5.2,
            Registered = @"2017-01-06T09:58:02-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/fi.png",
            CountryName = @"Finland"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 16,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/72.jpg",
            Position = @"down",
            Name = @"Felix Olsen",
            AthleteNumber = 43198,
            BeatsPerMinute = 101,
            TopSpeed = 4.2,
            Registered = @"2017-09-27T01:17:14-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/fr.png",
            CountryName = @"France"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 62,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/43.jpg",
            Position = @"current",
            Name = @"Roman Smith",
            AthleteNumber = 15531,
            BeatsPerMinute = 106,
            TopSpeed = 4.9,
            Registered = @"2017-06-14T05:12:04-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ga.png",
            CountryName = @"Gabon"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 69,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/17.jpg",
            Position = @"current",
            Name = @"Emil Meißner",
            AthleteNumber = 37183,
            BeatsPerMinute = 97,
            TopSpeed = 4,
            Registered = @"2017-07-15T12:32:30-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gm.png",
            CountryName = @"Gambia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 182,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/94.jpg",
            Position = @"current",
            Name = @"Gerald Schmidt",
            AthleteNumber = 47410,
            BeatsPerMinute = 102,
            TopSpeed = 5.8,
            Registered = @"2017-02-20T11:53:08-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ge.png",
            CountryName = @"Georgia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 190,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/53.jpg",
            Position = @"current",
            Name = @"Gladys Van Der Steeg",
            AthleteNumber = 20216,
            BeatsPerMinute = 94,
            TopSpeed = 4.3,
            Registered = @"2017-10-09T02:01:16-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/de.png",
            CountryName = @"Germany"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 100,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/20.jpg",
            Position = @"current",
            Name = @"Alexis Walker",
            AthleteNumber = 43183,
            BeatsPerMinute = 103,
            TopSpeed = 5.8,
            Registered = @"2017-08-07T10:35:06-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gh.png",
            CountryName = @"Ghana"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 85,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/34.jpg",
            Position = @"current",
            Name = @"Jeffrey Medina",
            AthleteNumber = 42905,
            BeatsPerMinute = 100,
            TopSpeed = 5.2,
            Registered = @"2017-09-15T02:11:43-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gr.png",
            CountryName = @"Greece"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 169,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/21.jpg",
            Position = @"down",
            Name = @"Julian Barth",
            AthleteNumber = 19011,
            BeatsPerMinute = 91,
            TopSpeed = 5.2,
            Registered = @"2017-04-21T08:08:33-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gd.png",
            CountryName = @"Grenada"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 116,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/1.jpg",
            Position = @"down",
            Name = @"Sevcan Kollen",
            AthleteNumber = 13728,
            BeatsPerMinute = 104,
            TopSpeed = 5.3,
            Registered = @"2017-09-08T08:29:08-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gt.png",
            CountryName = @"Guatemala"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 75,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/88.jpg",
            Position = @"down",
            Name = @"Rafael Gutierrez",
            AthleteNumber = 38804,
            BeatsPerMinute = 100,
            TopSpeed = 5.9,
            Registered = @"2017-02-08T07:50:59-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gn.png",
            CountryName = @"Guinea"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 121,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/48.jpg",
            Position = @"current",
            Name = @"Väinö Salmi",
            AthleteNumber = 29839,
            BeatsPerMinute = 107,
            TopSpeed = 5.5,
            Registered = @"2017-10-21T05:57:02-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gw.png",
            CountryName = @"Guinea-Bissau"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 180,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/90.jpg",
            Position = @"up",
            Name = @"Lillian Bowman",
            AthleteNumber = 35323,
            BeatsPerMinute = 103,
            TopSpeed = 4.5,
            Registered = @"2017-08-31T11:55:25-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gy.png",
            CountryName = @"Guyana"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 139,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/28.jpg",
            Position = @"current",
            Name = @"Annabell Barth",
            AthleteNumber = 41130,
            BeatsPerMinute = 103,
            TopSpeed = 5,
            Registered = @"2017-08-24T11:58:56-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ht.png",
            CountryName = @"Haiti"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 4,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/34.jpg",
            Position = @"down",
            Name = @"Mathys Martin",
            AthleteNumber = 32928,
            BeatsPerMinute = 98,
            TopSpeed = 5.5,
            Registered = @"2017-05-17T12:51:47-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/va.png",
            CountryName = @"Holy See (Vatican City State)"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 1,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/65.jpg",
            Position = @"down",
            Name = @"Louis Stewart",
            AthleteNumber = 48131,
            BeatsPerMinute = 103,
            TopSpeed = 5.7,
            Registered = @"2017-02-26T07:28:02-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/hn.png",
            CountryName = @"Honduras"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 190,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/2.jpg",
            Position = @"current",
            Name = @"Venla Korpela",
            AthleteNumber = 16454,
            BeatsPerMinute = 92,
            TopSpeed = 4.1,
            Registered = @"2017-08-22T10:36:38-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/hu.png",
            CountryName = @"Hungary"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 167,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/81.jpg",
            Position = @"down",
            Name = @"Milo Charles",
            AthleteNumber = 10661,
            BeatsPerMinute = 99,
            TopSpeed = 5.4,
            Registered = @"2017-07-20T09:00:22-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/is.png",
            CountryName = @"Iceland"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 62,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/9.jpg",
            Position = @"current",
            Name = @"Anthony Harcourt",
            AthleteNumber = 33649,
            BeatsPerMinute = 109,
            TopSpeed = 5.5,
            Registered = @"2017-06-14T11:10:20-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/in.png",
            CountryName = @"India"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 72,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/31.jpg",
            Position = @"up",
            Name = @"Aaron Robertson",
            AthleteNumber = 30727,
            BeatsPerMinute = 95,
            TopSpeed = 4.2,
            Registered = @"2017-08-23T09:37:40-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/id.png",
            CountryName = @"Indonesia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 2,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/14.jpg",
            Position = @"up",
            Name = @"Bill Fox",
            AthleteNumber = 18511,
            BeatsPerMinute = 91,
            TopSpeed = 5,
            Registered = @"2017-10-24T08:25:40-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ir.png",
            CountryName = @"Iran, Islamic Republic Of"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 58,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/30.jpg",
            Position = @"up",
            Name = @"Veera Saari",
            AthleteNumber = 40408,
            BeatsPerMinute = 100,
            TopSpeed = 4.7,
            Registered = @"2017-10-28T10:39:22-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/iq.png",
            CountryName = @"Iraq"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 87,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/35.jpg",
            Position = @"current",
            Name = @"Loïc Gerard",
            AthleteNumber = 31706,
            BeatsPerMinute = 102,
            TopSpeed = 4.4,
            Registered = @"2017-07-28T09:10:43-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ie.png",
            CountryName = @"Ireland"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 137,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/75.jpg",
            Position = @"up",
            Name = @"Gloria Caballero",
            AthleteNumber = 43379,
            BeatsPerMinute = 103,
            TopSpeed = 4.3,
            Registered = @"2017-08-10T08:27:45-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/il.png",
            CountryName = @"Israel"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 5,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/38.jpg",
            Position = @"current",
            Name = @"Gianne Godijn",
            AthleteNumber = 45945,
            BeatsPerMinute = 96,
            TopSpeed = 4.5,
            Registered = @"2017-03-22T03:23:12-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/it.png",
            CountryName = @"Italy"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 196,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/17.jpg",
            Position = @"current",
            Name = @"Parel Zuidhof",
            AthleteNumber = 32718,
            BeatsPerMinute = 105,
            TopSpeed = 5,
            Registered = @"2017-01-21T10:19:56-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/jm.png",
            CountryName = @"Jamaica"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 23,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/72.jpg",
            Position = @"down",
            Name = @"Gökhan Aşıkoğlu",
            AthleteNumber = 13890,
            BeatsPerMinute = 105,
            TopSpeed = 5.4,
            Registered = @"2017-03-31T06:14:26-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/jp.png",
            CountryName = @"Japan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 74,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/9.jpg",
            Position = @"up",
            Name = @"Minea Rantanen",
            AthleteNumber = 18835,
            BeatsPerMinute = 105,
            TopSpeed = 5,
            Registered = @"2017-01-24T07:30:43-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/jo.png",
            CountryName = @"Jordan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 92,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/4.jpg",
            Position = @"down",
            Name = @"Asta Hansen",
            AthleteNumber = 17222,
            BeatsPerMinute = 101,
            TopSpeed = 4.3,
            Registered = @"2017-01-08T02:41:56-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/kz.png",
            CountryName = @"Kazakhstan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 191,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/13.jpg",
            Position = @"up",
            Name = @"Sheryl Collins",
            AthleteNumber = 36473,
            BeatsPerMinute = 98,
            TopSpeed = 4.2,
            Registered = @"2017-03-23T12:54:35-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ke.png",
            CountryName = @"Kenya"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 166,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/74.jpg",
            Position = @"current",
            Name = @"Maria Parra",
            AthleteNumber = 39861,
            BeatsPerMinute = 106,
            TopSpeed = 6,
            Registered = @"2017-01-30T09:22:52-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ki.png",
            CountryName = @"Kiribati"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 73,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/33.jpg",
            Position = @"up",
            Name = @"Annabelle Besteman",
            AthleteNumber = 30560,
            BeatsPerMinute = 105,
            TopSpeed = 5.3,
            Registered = @"2017-11-11T02:04:19-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/kp.png",
            CountryName = @"Korea, Democratic PeopleS Republic of"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 182,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/14.jpg",
            Position = @"up",
            Name = @"Ariena Achterberg",
            AthleteNumber = 41330,
            BeatsPerMinute = 92,
            TopSpeed = 5.6,
            Registered = @"2017-10-22T02:15:39-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/kr.png",
            CountryName = @"Korea, Republic of"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 67,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/50.jpg",
            Position = @"current",
            Name = @"Villads Larsen",
            AthleteNumber = 44677,
            BeatsPerMinute = 93,
            TopSpeed = 5.7,
            Registered = @"2017-03-25T11:25:30-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/kw.png",
            CountryName = @"Kuwait"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 110,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/26.jpg",
            Position = @"down",
            Name = @"Emilie Morin",
            AthleteNumber = 26164,
            BeatsPerMinute = 98,
            TopSpeed = 4.9,
            Registered = @"2017-02-01T04:18:19-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/kg.png",
            CountryName = @"Kyrgyzstan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 31,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/56.jpg",
            Position = @"up",
            Name = @"Judd Campbell",
            AthleteNumber = 37365,
            BeatsPerMinute = 110,
            TopSpeed = 5,
            Registered = @"2017-10-19T11:01:10-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/la.png",
            CountryName = @"Lao PeopleS Democratic Republic"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 110,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/13.jpg",
            Position = @"current",
            Name = @"Özsu Keçeci",
            AthleteNumber = 29403,
            BeatsPerMinute = 106,
            TopSpeed = 4.2,
            Registered = @"2017-01-19T11:34:13-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/lv.png",
            CountryName = @"Latvia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 123,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/12.jpg",
            Position = @"up",
            Name = @"آنیتا كامياران",
            AthleteNumber = 18980,
            BeatsPerMinute = 90,
            TopSpeed = 4.5,
            Registered = @"2017-07-21T06:42:59-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/lb.png",
            CountryName = @"Lebanon"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 138,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/31.jpg",
            Position = @"down",
            Name = @"Antoine Mackay",
            AthleteNumber = 34547,
            BeatsPerMinute = 104,
            TopSpeed = 5,
            Registered = @"2017-08-22T09:11:37-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ls.png",
            CountryName = @"Lesotho"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 167,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/19.jpg",
            Position = @"down",
            Name = @"Louis Smith",
            AthleteNumber = 31837,
            BeatsPerMinute = 98,
            TopSpeed = 5.4,
            Registered = @"2017-03-19T08:12:23-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/lr.png",
            CountryName = @"Liberia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 29,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/29.jpg",
            Position = @"current",
            Name = @"Selmo Caldeira",
            AthleteNumber = 21837,
            BeatsPerMinute = 110,
            TopSpeed = 4.9,
            Registered = @"2017-10-20T03:40:24-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ly.png",
            CountryName = @"Libyan Arab Jamahiriya"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 35,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/42.jpg",
            Position = @"down",
            Name = @"Elaine Smith",
            AthleteNumber = 38243,
            BeatsPerMinute = 108,
            TopSpeed = 4,
            Registered = @"2017-06-11T12:20:41-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/li.png",
            CountryName = @"Liechtenstein"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 75,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/2.jpg",
            Position = @"up",
            Name = @"Fritz Sommer",
            AthleteNumber = 26210,
            BeatsPerMinute = 99,
            TopSpeed = 4.6,
            Registered = @"2017-09-29T03:54:57-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/lt.png",
            CountryName = @"Lithuania"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 40,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/5.jpg",
            Position = @"down",
            Name = @"Carter Evans",
            AthleteNumber = 46961,
            BeatsPerMinute = 100,
            TopSpeed = 5.3,
            Registered = @"2017-07-23T02:43:07-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/lu.png",
            CountryName = @"Luxembourg"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 183,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/53.jpg",
            Position = @"up",
            Name = @"رونیکا سلطانی نژاد",
            AthleteNumber = 35233,
            BeatsPerMinute = 99,
            TopSpeed = 4.6,
            Registered = @"2017-08-13T01:05:52-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mk.png",
            CountryName = @"Macedonia, The Former Yugoslav Republic of"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 151,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/88.jpg",
            Position = @"current",
            Name = @"Charlotte Mills",
            AthleteNumber = 49829,
            BeatsPerMinute = 92,
            TopSpeed = 5.3,
            Registered = @"2017-05-10T04:33:10-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mg.png",
            CountryName = @"Madagascar"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 107,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/33.jpg",
            Position = @"up",
            Name = @"Pedro Marquez",
            AthleteNumber = 16169,
            BeatsPerMinute = 97,
            TopSpeed = 5.4,
            Registered = @"2017-11-11T05:14:31-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mw.png",
            CountryName = @"Malawi"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 65,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/9.jpg",
            Position = @"down",
            Name = @"Jenny Burke",
            AthleteNumber = 15266,
            BeatsPerMinute = 99,
            TopSpeed = 5.4,
            Registered = @"2017-09-11T12:20:19-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/my.png",
            CountryName = @"Malaysia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 155,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/82.jpg",
            Position = @"up",
            Name = @"Justin Philippe",
            AthleteNumber = 12858,
            BeatsPerMinute = 104,
            TopSpeed = 5.7,
            Registered = @"2017-03-16T02:00:35-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mv.png",
            CountryName = @"Maldives"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 165,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/79.jpg",
            Position = @"down",
            Name = @"Mario Ellis",
            AthleteNumber = 18026,
            BeatsPerMinute = 99,
            TopSpeed = 5.5,
            Registered = @"2017-02-13T11:53:15-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ml.png",
            CountryName = @"Mali"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 107,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/92.jpg",
            Position = @"down",
            Name = @"Megan Webb",
            AthleteNumber = 30713,
            BeatsPerMinute = 93,
            TopSpeed = 5.6,
            Registered = @"2017-08-20T09:26:51-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mt.png",
            CountryName = @"Malta"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 52,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/94.jpg",
            Position = @"down",
            Name = @"Adérito Lopes",
            AthleteNumber = 21320,
            BeatsPerMinute = 91,
            TopSpeed = 5.2,
            Registered = @"2017-01-07T06:47:56-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mh.png",
            CountryName = @"Marshall Islands"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 99,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/89.jpg",
            Position = @"down",
            Name = @"Victor Lévesque",
            AthleteNumber = 48375,
            BeatsPerMinute = 110,
            TopSpeed = 5.7,
            Registered = @"2017-11-10T11:31:44-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mr.png",
            CountryName = @"Mauritania"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 188,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/81.jpg",
            Position = @"down",
            Name = @"آراد یاسمی",
            AthleteNumber = 34370,
            BeatsPerMinute = 99,
            TopSpeed = 5.9,
            Registered = @"2017-02-02T11:42:41-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mu.png",
            CountryName = @"Mauritius"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 10,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/13.jpg",
            Position = @"down",
            Name = @"Maeva Bergeron",
            AthleteNumber = 15655,
            BeatsPerMinute = 94,
            TopSpeed = 5.9,
            Registered = @"2017-10-03T09:42:15-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mx.png",
            CountryName = @"Mexico"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 41,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/20.jpg",
            Position = @"up",
            Name = @"Oskari Karjala",
            AthleteNumber = 31498,
            BeatsPerMinute = 90,
            TopSpeed = 4.5,
            Registered = @"2017-05-10T12:45:12-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/fm.png",
            CountryName = @"Micronesia, Federated States of"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 51,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/74.jpg",
            Position = @"up",
            Name = @"Alex Meyer",
            AthleteNumber = 44390,
            BeatsPerMinute = 94,
            TopSpeed = 4.3,
            Registered = @"2017-08-04T07:05:34-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/md.png",
            CountryName = @"Moldova, Republic of"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 128,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/52.jpg",
            Position = @"up",
            Name = @"Sophie Lewis",
            AthleteNumber = 46222,
            BeatsPerMinute = 106,
            TopSpeed = 4.4,
            Registered = @"2017-02-20T09:42:07-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mc.png",
            CountryName = @"Monaco"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 79,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/39.jpg",
            Position = @"current",
            Name = @"Ashley Romero",
            AthleteNumber = 36611,
            BeatsPerMinute = 104,
            TopSpeed = 5.5,
            Registered = @"2017-02-08T12:45:46-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mn.png",
            CountryName = @"Mongolia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 124,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/19.jpg",
            Position = @"current",
            Name = @"Marie Poulsen",
            AthleteNumber = 44113,
            BeatsPerMinute = 109,
            TopSpeed = 4.7,
            Registered = @"2017-04-15T10:25:21-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ma.png",
            CountryName = @"Morocco"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 42,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/83.jpg",
            Position = @"down",
            Name = @"Caitlin Jackson",
            AthleteNumber = 45472,
            BeatsPerMinute = 101,
            TopSpeed = 4.3,
            Registered = @"2017-09-17T09:41:01-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mz.png",
            CountryName = @"Mozambique"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 15,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/79.jpg",
            Position = @"down",
            Name = @"Marilou Hubert",
            AthleteNumber = 43655,
            BeatsPerMinute = 104,
            TopSpeed = 4.2,
            Registered = @"2017-09-28T11:13:00-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/mm.png",
            CountryName = @"Myanmar"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 63,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/9.jpg",
            Position = @"up",
            Name = @"Estelle Vincent",
            AthleteNumber = 41700,
            BeatsPerMinute = 99,
            TopSpeed = 5.7,
            Registered = @"2017-05-31T02:56:58-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/na.png",
            CountryName = @"Namibia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 154,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/54.jpg",
            Position = @"down",
            Name = @"Rhonda Simmmons",
            AthleteNumber = 37139,
            BeatsPerMinute = 96,
            TopSpeed = 5.1,
            Registered = @"2017-07-03T05:39:45-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/nr.png",
            CountryName = @"Nauru"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 191,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/42.jpg",
            Position = @"current",
            Name = @"آرش احمدی",
            AthleteNumber = 36948,
            BeatsPerMinute = 90,
            TopSpeed = 4.1,
            Registered = @"2017-09-08T01:22:14-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/np.png",
            CountryName = @"Nepal"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 141,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/15.jpg",
            Position = @"current",
            Name = @"Miro Korpela",
            AthleteNumber = 40544,
            BeatsPerMinute = 104,
            TopSpeed = 5.3,
            Registered = @"2017-01-10T07:12:44-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/nl.png",
            CountryName = @"Netherlands"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 73,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/4.jpg",
            Position = @"up",
            Name = @"Afet Kumcuoğlu",
            AthleteNumber = 33454,
            BeatsPerMinute = 106,
            TopSpeed = 5.1,
            Registered = @"2017-09-16T07:05:43-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/nz.png",
            CountryName = @"New Zealand"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 163,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/52.jpg",
            Position = @"up",
            Name = @"Millie Cooper",
            AthleteNumber = 14610,
            BeatsPerMinute = 99,
            TopSpeed = 5.4,
            Registered = @"2017-05-08T09:30:14-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ni.png",
            CountryName = @"Nicaragua"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 53,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/51.jpg",
            Position = @"current",
            Name = @"Kayla Patel",
            AthleteNumber = 42780,
            BeatsPerMinute = 103,
            TopSpeed = 4.7,
            Registered = @"2017-04-20T09:33:53-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ne.png",
            CountryName = @"Niger"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 58,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/31.jpg",
            Position = @"current",
            Name = @"Diego Gautier",
            AthleteNumber = 26320,
            BeatsPerMinute = 97,
            TopSpeed = 4.6,
            Registered = @"2017-06-11T03:50:43-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ng.png",
            CountryName = @"Nigeria"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 186,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/2.jpg",
            Position = @"up",
            Name = @"کوروش کامروا",
            AthleteNumber = 13506,
            BeatsPerMinute = 109,
            TopSpeed = 4.4,
            Registered = @"2017-04-16T01:10:37-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/nu.png",
            CountryName = @"Niue"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 101,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/71.jpg",
            Position = @"down",
            Name = @"Lavínia Silva",
            AthleteNumber = 33994,
            BeatsPerMinute = 93,
            TopSpeed = 5.6,
            Registered = @"2017-03-22T08:55:46-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/no.png",
            CountryName = @"Norway"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 194,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/71.jpg",
            Position = @"down",
            Name = @"Adrian Ibañez",
            AthleteNumber = 21968,
            BeatsPerMinute = 105,
            TopSpeed = 5.3,
            Registered = @"2017-02-03T04:36:54-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/om.png",
            CountryName = @"Oman"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 143,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/38.jpg",
            Position = @"up",
            Name = @"رضا کوتی",
            AthleteNumber = 13640,
            BeatsPerMinute = 103,
            TopSpeed = 4.2,
            Registered = @"2017-04-30T02:34:29-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/pk.png",
            CountryName = @"Pakistan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 37,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/86.jpg",
            Position = @"down",
            Name = @"Clyde Matthews",
            AthleteNumber = 11955,
            BeatsPerMinute = 93,
            TopSpeed = 5.2,
            Registered = @"2017-03-02T05:01:02-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/pw.png",
            CountryName = @"Palau"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 176,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/26.jpg",
            Position = @"current",
            Name = @"Tim Neal",
            AthleteNumber = 45860,
            BeatsPerMinute = 97,
            TopSpeed = 5.6,
            Registered = @"2017-04-21T04:06:34-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/pa.png",
            CountryName = @"Panama"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 110,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/15.jpg",
            Position = @"current",
            Name = @"Annabell Brand",
            AthleteNumber = 39233,
            BeatsPerMinute = 93,
            TopSpeed = 5.7,
            Registered = @"2017-03-01T12:21:24-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/pg.png",
            CountryName = @"Papua New Guinea"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 188,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/3.jpg",
            Position = @"current",
            Name = @"Foppe Delfos",
            AthleteNumber = 39679,
            BeatsPerMinute = 107,
            TopSpeed = 4.1,
            Registered = @"2017-08-05T10:54:56-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/py.png",
            CountryName = @"Paraguay"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 43,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/42.jpg",
            Position = @"up",
            Name = @"Kent Clark",
            AthleteNumber = 32799,
            BeatsPerMinute = 106,
            TopSpeed = 5.7,
            Registered = @"2017-01-24T01:00:15-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/pe.png",
            CountryName = @"Peru"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 167,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/32.jpg",
            Position = @"current",
            Name = @"Esma Adıvar",
            AthleteNumber = 35565,
            BeatsPerMinute = 99,
            TopSpeed = 4.2,
            Registered = @"2017-06-17T12:34:29-03:00",
            TrackProgress = 75,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ph.png",
            CountryName = @"Philippines"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 123,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/19.jpg",
            Position = @"down",
            Name = @"Flora Perez",
            AthleteNumber = 23907,
            BeatsPerMinute = 102,
            TopSpeed = 5.8,
            Registered = @"2017-04-12T04:16:56-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/pl.png",
            CountryName = @"Poland"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 76,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/65.jpg",
            Position = @"current",
            Name = @"David Scott",
            AthleteNumber = 46997,
            BeatsPerMinute = 101,
            TopSpeed = 4.4,
            Registered = @"2017-07-25T09:23:24-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/pt.png",
            CountryName = @"Portugal"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 183,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/74.jpg",
            Position = @"down",
            Name = @"Yarno Kin",
            AthleteNumber = 47324,
            BeatsPerMinute = 107,
            TopSpeed = 5.1,
            Registered = @"2017-08-26T08:21:22-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ro.png",
            CountryName = @"Romania"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 8,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/15.jpg",
            Position = @"down",
            Name = @"Esther Kühn",
            AthleteNumber = 24868,
            BeatsPerMinute = 92,
            TopSpeed = 5.5,
            Registered = @"2017-05-14T12:30:08-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ru.png",
            CountryName = @"Russian Federation"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 80,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/90.jpg",
            Position = @"down",
            Name = @"Cecil Nichols",
            AthleteNumber = 20656,
            BeatsPerMinute = 100,
            TopSpeed = 5,
            Registered = @"2017-04-24T01:20:34-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/rw.png",
            CountryName = @"RWANDA"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 41,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/65.jpg",
            Position = @"down",
            Name = @"Lilly Keuter",
            AthleteNumber = 49893,
            BeatsPerMinute = 102,
            TopSpeed = 4.5,
            Registered = @"2017-01-20T02:38:39-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/kn.png",
            CountryName = @"Saint Kitts and Nevis"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 200,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/73.jpg",
            Position = @"current",
            Name = @"Alice Perry",
            AthleteNumber = 23750,
            BeatsPerMinute = 104,
            TopSpeed = 5.3,
            Registered = @"2017-03-31T07:15:46-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/lc.png",
            CountryName = @"Saint Lucia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 51,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/34.jpg",
            Position = @"down",
            Name = @"Eléa Robin",
            AthleteNumber = 26742,
            BeatsPerMinute = 90,
            TopSpeed = 4.7,
            Registered = @"2017-03-30T12:34:24-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/vc.png",
            CountryName = @"Saint Vincent and the Grenadines"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 163,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/70.jpg",
            Position = @"down",
            Name = @"میلاد قاسمی",
            AthleteNumber = 12788,
            BeatsPerMinute = 101,
            TopSpeed = 4.1,
            Registered = @"2017-03-01T07:51:17-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ws.png",
            CountryName = @"Samoa"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 72,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/26.jpg",
            Position = @"down",
            Name = @"Sélène Roussel",
            AthleteNumber = 11261,
            BeatsPerMinute = 99,
            TopSpeed = 5.8,
            Registered = @"2017-05-10T02:18:02-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sm.png",
            CountryName = @"San Marino"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 159,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/66.jpg",
            Position = @"up",
            Name = @"Eva Dean",
            AthleteNumber = 48874,
            BeatsPerMinute = 103,
            TopSpeed = 5.7,
            Registered = @"2017-03-04T01:58:52-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/st.png",
            CountryName = @"Sao Tome and Principe"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 12,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/83.jpg",
            Position = @"up",
            Name = @"Sara Larsen",
            AthleteNumber = 37094,
            BeatsPerMinute = 97,
            TopSpeed = 4.5,
            Registered = @"2017-04-14T11:48:28-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sa.png",
            CountryName = @"Saudi Arabia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 194,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/11.jpg",
            Position = @"down",
            Name = @"Kaya Taşlı",
            AthleteNumber = 42291,
            BeatsPerMinute = 100,
            TopSpeed = 4.7,
            Registered = @"2017-01-30T03:23:36-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sn.png",
            CountryName = @"Senegal"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 162,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/5.jpg",
            Position = @"down",
            Name = @"Adam Bouchard",
            AthleteNumber = 38672,
            BeatsPerMinute = 99,
            TopSpeed = 4.7,
            Registered = @"2017-01-04T03:04:05-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sc.png",
            CountryName = @"Seychelles"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 96,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/37.jpg",
            Position = @"up",
            Name = @"Thea Edwards",
            AthleteNumber = 29141,
            BeatsPerMinute = 99,
            TopSpeed = 5.8,
            Registered = @"2017-05-23T05:24:38-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sl.png",
            CountryName = @"Sierra Leone"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 93,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/90.jpg",
            Position = @"current",
            Name = @"Ana Bourgeois",
            AthleteNumber = 24612,
            BeatsPerMinute = 110,
            TopSpeed = 6,
            Registered = @"2017-11-02T02:17:43-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sg.png",
            CountryName = @"Singapore"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 27,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/61.jpg",
            Position = @"up",
            Name = @"Layla Douglas",
            AthleteNumber = 21977,
            BeatsPerMinute = 97,
            TopSpeed = 5.4,
            Registered = @"2017-04-19T11:43:38-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/si.png",
            CountryName = @"Slovenia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 178,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/65.jpg",
            Position = @"down",
            Name = @"Lillian Wade",
            AthleteNumber = 10729,
            BeatsPerMinute = 110,
            TopSpeed = 4.8,
            Registered = @"2017-04-07T09:53:13-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sb.png",
            CountryName = @"Solomon Islands"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 192,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/44.jpg",
            Position = @"down",
            Name = @"Viivi Kujala",
            AthleteNumber = 29939,
            BeatsPerMinute = 93,
            TopSpeed = 4.1,
            Registered = @"2017-05-03T02:40:05-03:00",
            TrackProgress = 75,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/so.png",
            CountryName = @"Somalia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 87,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/72.jpg",
            Position = @"up",
            Name = @"Charlotte Dean",
            AthleteNumber = 45969,
            BeatsPerMinute = 105,
            TopSpeed = 5,
            Registered = @"2017-02-13T05:39:15-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/za.png",
            CountryName = @"South Africa"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 86,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/45.jpg",
            Position = @"down",
            Name = @"Marisvalda Martins",
            AthleteNumber = 33879,
            BeatsPerMinute = 107,
            TopSpeed = 5.4,
            Registered = @"2017-01-31T12:07:48-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/es.png",
            CountryName = @"Spain"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 129,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/34.jpg",
            Position = @"up",
            Name = @"Ella Hansen",
            AthleteNumber = 27075,
            BeatsPerMinute = 101,
            TopSpeed = 5.1,
            Registered = @"2017-01-05T10:12:42-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/lk.png",
            CountryName = @"Sri Lanka"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 27,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/9.jpg",
            Position = @"current",
            Name = @"Johann Hinz",
            AthleteNumber = 48244,
            BeatsPerMinute = 94,
            TopSpeed = 4.3,
            Registered = @"2017-03-10T07:36:56-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sd.png",
            CountryName = @"Sudan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 113,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/37.jpg",
            Position = @"current",
            Name = @"Nick Naumann",
            AthleteNumber = 25566,
            BeatsPerMinute = 109,
            TopSpeed = 5.9,
            Registered = @"2017-07-12T09:01:11-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sz.png",
            CountryName = @"Swaziland"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 194,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/62.jpg",
            Position = @"up",
            Name = @"آوا سلطانی نژاد",
            AthleteNumber = 45635,
            BeatsPerMinute = 98,
            TopSpeed = 4.1,
            Registered = @"2017-04-10T11:39:46-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/se.png",
            CountryName = @"Sweden"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 65,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/47.jpg",
            Position = @"current",
            Name = @"Ilke Kisters",
            AthleteNumber = 23817,
            BeatsPerMinute = 100,
            TopSpeed = 5.9,
            Registered = @"2017-01-04T02:54:53-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ch.png",
            CountryName = @"Switzerland"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 162,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/0.jpg",
            Position = @"current",
            Name = @"Alex Craig",
            AthleteNumber = 21868,
            BeatsPerMinute = 94,
            TopSpeed = 4.2,
            Registered = @"2017-03-19T10:20:51-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/sy.png",
            CountryName = @"Syrian Arab Republic"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 161,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/89.jpg",
            Position = @"up",
            Name = @"Franklin Byrd",
            AthleteNumber = 49498,
            BeatsPerMinute = 106,
            TopSpeed = 5.3,
            Registered = @"2017-11-04T11:09:26-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tw.png",
            CountryName = @"Taiwan, Province of China"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 167,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/62.jpg",
            Position = @"current",
            Name = @"Pippa Morris",
            AthleteNumber = 44421,
            BeatsPerMinute = 101,
            TopSpeed = 5.5,
            Registered = @"2017-03-06T09:21:58-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tj.png",
            CountryName = @"Tajikistan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 43,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/94.jpg",
            Position = @"up",
            Name = @"Emma Turner",
            AthleteNumber = 39487,
            BeatsPerMinute = 110,
            TopSpeed = 5.7,
            Registered = @"2017-07-30T01:33:14-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tz.png",
            CountryName = @"Tanzania, United Republic of"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 76,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/1.jpg",
            Position = @"current",
            Name = @"Encarnacion Martin",
            AthleteNumber = 40912,
            BeatsPerMinute = 105,
            TopSpeed = 5.5,
            Registered = @"2017-01-11T12:52:28-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/th.png",
            CountryName = @"Thailand"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 93,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/21.jpg",
            Position = @"up",
            Name = @"Sara Hannula",
            AthleteNumber = 22025,
            BeatsPerMinute = 102,
            TopSpeed = 4.2,
            Registered = @"2017-10-09T11:32:13-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tl.png",
            CountryName = @"Timor-Leste"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 147,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/8.jpg",
            Position = @"down",
            Name = @"میلاد یاسمی",
            AthleteNumber = 44023,
            BeatsPerMinute = 104,
            TopSpeed = 5.2,
            Registered = @"2017-06-10T04:11:01-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tg.png",
            CountryName = @"Togo"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 131,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/61.jpg",
            Position = @"down",
            Name = @"Veronika Huber",
            AthleteNumber = 18146,
            BeatsPerMinute = 103,
            TopSpeed = 5.2,
            Registered = @"2017-07-13T02:23:56-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/to.png",
            CountryName = @"Tonga"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 122,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/71.jpg",
            Position = @"down",
            Name = @"Natalie Conrad",
            AthleteNumber = 42602,
            BeatsPerMinute = 108,
            TopSpeed = 6,
            Registered = @"2017-03-18T06:35:44-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tt.png",
            CountryName = @"Trinidad and Tobago"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 113,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/36.jpg",
            Position = @"current",
            Name = @"Marialba Nascimento",
            AthleteNumber = 47061,
            BeatsPerMinute = 108,
            TopSpeed = 5.2,
            Registered = @"2017-09-19T05:47:21-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tn.png",
            CountryName = @"Tunisia"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 135,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/84.jpg",
            Position = @"down",
            Name = @"Darryl Douglas",
            AthleteNumber = 35826,
            BeatsPerMinute = 96,
            TopSpeed = 4.6,
            Registered = @"2017-07-20T11:45:52-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tr.png",
            CountryName = @"Turkey"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 130,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/94.jpg",
            Position = @"up",
            Name = @"Adem Özdoğan",
            AthleteNumber = 45143,
            BeatsPerMinute = 90,
            TopSpeed = 5.5,
            Registered = @"2017-02-16T07:11:52-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tm.png",
            CountryName = @"Turkmenistan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 14,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/84.jpg",
            Position = @"up",
            Name = @"Ömür Denkel",
            AthleteNumber = 31061,
            BeatsPerMinute = 104,
            TopSpeed = 4.5,
            Registered = @"2017-02-18T05:32:55-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/tv.png",
            CountryName = @"Tuvalu"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 43,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/77.jpg",
            Position = @"down",
            Name = @"Cathalijne Van Der Ree",
            AthleteNumber = 45160,
            BeatsPerMinute = 102,
            TopSpeed = 5.4,
            Registered = @"2017-02-13T05:23:49-02:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ug.png",
            CountryName = @"Uganda"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 164,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/51.jpg",
            Position = @"current",
            Name = @"Ethel Stephens",
            AthleteNumber = 18692,
            BeatsPerMinute = 94,
            TopSpeed = 4.1,
            Registered = @"2017-02-13T05:03:04-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ua.png",
            CountryName = @"Ukraine"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 167,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/67.jpg",
            Position = @"down",
            Name = @"Aatu Ranta",
            AthleteNumber = 38049,
            BeatsPerMinute = 94,
            TopSpeed = 5.1,
            Registered = @"2017-07-21T04:22:18-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ae.png",
            CountryName = @"United Arab Emirates"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 169,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/44.jpg",
            Position = @"up",
            Name = @"Aziz Santos",
            AthleteNumber = 38947,
            BeatsPerMinute = 98,
            TopSpeed = 4,
            Registered = @"2017-04-03T02:18:46-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/gb.png",
            CountryName = @"United Kingdom"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 170,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/60.jpg",
            Position = @"up",
            Name = @"Fernando Gimenez",
            AthleteNumber = 31290,
            BeatsPerMinute = 102,
            TopSpeed = 5.1,
            Registered = @"2017-06-21T06:45:54-03:00",
            TrackProgress = 60,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/uz.png",
            CountryName = @"Uruguay"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 124,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/98.jpg",
            Position = @"down",
            Name = @"Mathieu Mathieu",
            AthleteNumber = 10555,
            BeatsPerMinute = 101,
            TopSpeed = 5.2,
            Registered = @"2017-01-05T07:28:11-02:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/uz.png",
            CountryName = @"Uzbekistan"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 193,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/9.jpg",
            Position = @"down",
            Name = @"Juanita Franklin",
            AthleteNumber = 13907,
            BeatsPerMinute = 91,
            TopSpeed = 6,
            Registered = @"2017-10-04T02:46:46-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/vu.png",
            CountryName = @"Vanuatu"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 25,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/men/42.jpg",
            Position = @"up",
            Name = @"Stanley Hart",
            AthleteNumber = 14150,
            BeatsPerMinute = 91,
            TopSpeed = 4.5,
            Registered = @"2017-08-19T03:02:33-03:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ve.png",
            CountryName = @"Venezuela"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 131,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/61.jpg",
            Position = @"current",
            Name = @"Eliza Bishop",
            AthleteNumber = 31774,
            BeatsPerMinute = 96,
            TopSpeed = 4.7,
            Registered = @"2017-09-22T11:49:02-03:00",
            TrackProgress = 45,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/eh.png",
            CountryName = @"Western Sahara"
        });
        this.Add(new AthletesDataItem()
        {
            Id = 34,
            Avatar = @"https://static.infragistics.com/xplatform/images/people/women/19.jpg",
            Position = @"down",
            Name = @"Linda Schäfer",
            AthleteNumber = 43074,
            BeatsPerMinute = 107,
            TopSpeed = 5.1,
            Registered = @"2017-01-05T11:41:20-02:00",
            TrackProgress = 25,
            CountryFlag = @"https://static.infragistics.com/xplatform/images/flags/iso2/ye.png",
            CountryName = @"Yemen"
        });
    }
}