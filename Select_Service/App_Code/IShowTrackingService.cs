using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShowTrackingService" in both code and config file together.
[ServiceContract]
public interface IShowTrackingService
{
    [OperationContract]
    List<string> GetVenueNames();

    [OperationContract]
    List<string> GetArtistNames();

    [OperationContract]
    List<string> GetShowNames();

    [OperationContract]
    List<ShowsPerVenue> GetVenueShows(string venueName);

    [OperationContract]
    List<ShowsPerArtist> GetArtistShows(string artist);

}
[DataContract]

public class ShowsPerVenue
{
    [DataMember]
    public string VenueShowName { set; get; }

    [DataMember]
    public string VenueShowDate { set; get; }

    [DataMember]
    public string VenueShowTime { set; get; }
}

[DataContract]
public class ShowsPerArtist
{
    [DataMember]
    public string ArtistShowName { set; get; }

    [DataMember]
    public string ArtistShowDate { set; get; }

    [DataMember]
    public string ArtistShowTime { set; get; }

    [DataMember]
    public string ArtistVenueName { set; get; }
}
