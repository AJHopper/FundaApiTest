using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace FundaApiTest.WrappingApi.Models
{
	// Classes auto generated using https://xmltocsharp.azurewebsites.net/ to allow easy mapping from XML to workable C# classes.


	[XmlRoot(ElementName = "ValidationReport", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class ValidationReport
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
		[XmlAttribute(AttributeName = "a", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string A { get; set; }
	}

	[XmlRoot(ElementName = "Metadata", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Metadata
	{
		[XmlElement(ElementName = "ObjectType", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string ObjectType { get; set; }
		[XmlElement(ElementName = "Omschrijving", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Omschrijving { get; set; }
		[XmlElement(ElementName = "Titel", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Titel { get; set; }
	}

	[XmlRoot(ElementName = "AantalBeschikbaar", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class AantalBeschikbaar
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "AantalKavels", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class AantalKavels
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "DatumAanvaarding", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class DatumAanvaarding
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "DatumOndertekeningAkte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class DatumOndertekeningAkte
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "GewijzigdDatum", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class GewijzigdDatum
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "HuurPrijsTot", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class HuurPrijsTot
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Huurprijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Huurprijs
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "HuurprijsFormaat", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class HuurprijsFormaat
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "InUnitsVanaf", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class InUnitsVanaf
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "IndTransactieMakelaarTonen", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class IndTransactieMakelaarTonen
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Note", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Note
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "OpenHuis", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class OpenHuis
	{
		[XmlAttribute(AttributeName = "a", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string A { get; set; }
	}

	[XmlRoot(ElementName = "Perceeloppervlakte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Perceeloppervlakte
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "HuurprijsTot", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class HuurprijsTot
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "OriginelePrijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class OriginelePrijs
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Prijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Prijs
	{
		[XmlElement(ElementName = "GeenExtraKosten", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string GeenExtraKosten { get; set; }
		[XmlElement(ElementName = "HuurAbbreviation", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HuurAbbreviation { get; set; }
		[XmlElement(ElementName = "Huurprijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Huurprijs Huurprijs { get; set; }
		[XmlElement(ElementName = "HuurprijsOpAanvraag", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HuurprijsOpAanvraag { get; set; }
		[XmlElement(ElementName = "HuurprijsTot", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public HuurprijsTot HuurprijsTot { get; set; }
		[XmlElement(ElementName = "KoopAbbreviation", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string KoopAbbreviation { get; set; }
		[XmlElement(ElementName = "Koopprijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Koopprijs { get; set; }
		[XmlElement(ElementName = "KoopprijsOpAanvraag", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string KoopprijsOpAanvraag { get; set; }
		[XmlElement(ElementName = "KoopprijsTot", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string KoopprijsTot { get; set; }
		[XmlElement(ElementName = "OriginelePrijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public OriginelePrijs OriginelePrijs { get; set; }
		[XmlElement(ElementName = "VeilingText", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string VeilingText { get; set; }
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Producten", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Producten
	{
		[XmlElement(ElementName = "string", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
		public List<string> String { get; set; }
		[XmlAttribute(AttributeName = "a", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string A { get; set; }
	}

	[XmlRoot(ElementName = "AantalKamersTotEnMet", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class AantalKamersTotEnMet
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "AantalKamersVan", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class AantalKamersVan
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Adres", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Adres
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "FriendlyUrl", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class FriendlyUrl
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "GlobalId", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class GlobalId
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "MaxWoonoppervlakte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class MaxWoonoppervlakte
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "MinWoonoppervlakte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class MinWoonoppervlakte
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Naam", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Naam
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Omschrijving", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Omschrijving
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Plaats", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Plaats
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "PrijsGeformatteerd", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class PrijsGeformatteerd
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "PublicatieDatum", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class PublicatieDatum
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Woningtypen", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Woningtypen
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
		[XmlAttribute(AttributeName = "a", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string A { get; set; }
	}

	[XmlRoot(ElementName = "Project", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Project
	{
		[XmlElement(ElementName = "AantalKamersTotEnMet", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public AantalKamersTotEnMet AantalKamersTotEnMet { get; set; }
		[XmlElement(ElementName = "AantalKamersVan", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public AantalKamersVan AantalKamersVan { get; set; }
		[XmlElement(ElementName = "AantalKavels", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public AantalKavels AantalKavels { get; set; }
		[XmlElement(ElementName = "Adres", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Adres Adres { get; set; }
		[XmlElement(ElementName = "FriendlyUrl", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public FriendlyUrl FriendlyUrl { get; set; }
		[XmlElement(ElementName = "GewijzigdDatum", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public GewijzigdDatum GewijzigdDatum { get; set; }
		[XmlElement(ElementName = "GlobalId", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public GlobalId GlobalId { get; set; }
		[XmlElement(ElementName = "HoofdFoto", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HoofdFoto { get; set; }
		[XmlElement(ElementName = "IndIpix", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IndIpix { get; set; }
		[XmlElement(ElementName = "IndPDF", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IndPDF { get; set; }
		[XmlElement(ElementName = "IndPlattegrond", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IndPlattegrond { get; set; }
		[XmlElement(ElementName = "IndTop", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IndTop { get; set; }
		[XmlElement(ElementName = "IndVideo", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IndVideo { get; set; }
		[XmlElement(ElementName = "InternalId", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string InternalId { get; set; }
		[XmlElement(ElementName = "MaxWoonoppervlakte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public MaxWoonoppervlakte MaxWoonoppervlakte { get; set; }
		[XmlElement(ElementName = "MinWoonoppervlakte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public MinWoonoppervlakte MinWoonoppervlakte { get; set; }
		[XmlElement(ElementName = "Naam", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Naam Naam { get; set; }
		[XmlElement(ElementName = "Omschrijving", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Omschrijving Omschrijving { get; set; }
		[XmlElement(ElementName = "OpenHuizen", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string OpenHuizen { get; set; }
		[XmlElement(ElementName = "Plaats", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Plaats Plaats { get; set; }
		[XmlElement(ElementName = "Prijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Prijs Prijs { get; set; }
		[XmlElement(ElementName = "PrijsGeformatteerd", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public PrijsGeformatteerd PrijsGeformatteerd { get; set; }
		[XmlElement(ElementName = "PublicatieDatum", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public PublicatieDatum PublicatieDatum { get; set; }
		[XmlElement(ElementName = "Type", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Type { get; set; }
		[XmlElement(ElementName = "Woningtypen", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Woningtypen Woningtypen { get; set; }
	}

	[XmlRoot(ElementName = "ProjectNaam", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class ProjectNaam
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "PromotionPhotos", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
	public class PromotionPhotos
	{
		[XmlAttribute(AttributeName = "b", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string B { get; set; }
	}

	[XmlRoot(ElementName = "PromotionPhotosSecure", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
	public class PromotionPhotosSecure
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
		[XmlAttribute(AttributeName = "b", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string B { get; set; }
	}

	[XmlRoot(ElementName = "RibbonText", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
	public class RibbonText
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Tagline", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
	public class Tagline
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "PromoLabel", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class PromoLabel
	{
		[XmlElement(ElementName = "HasPromotionLabel", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
		public string HasPromotionLabel { get; set; }
		[XmlElement(ElementName = "PromotionPhotos", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
		public PromotionPhotos PromotionPhotos { get; set; }
		[XmlElement(ElementName = "PromotionPhotosSecure", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
		public PromotionPhotosSecure PromotionPhotosSecure { get; set; }
		[XmlElement(ElementName = "PromotionType", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
		public string PromotionType { get; set; }
		[XmlElement(ElementName = "RibbonColor", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
		public string RibbonColor { get; set; }
		[XmlElement(ElementName = "RibbonText", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
		public RibbonText RibbonText { get; set; }
		[XmlElement(ElementName = "Tagline", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities.Detail")]
		public Tagline Tagline { get; set; }
		[XmlAttribute(AttributeName = "a", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string A { get; set; }
	}

	[XmlRoot(ElementName = "SavedDate", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class SavedDate
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "StartOplevering", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class StartOplevering
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "TimeAgoText", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class TimeAgoText
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "TransactieAfmeldDatum", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class TransactieAfmeldDatum
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "TransactieMakelaarId", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class TransactieMakelaarId
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "TransactieMakelaarNaam", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class TransactieMakelaarNaam
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "ZoekType", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class ZoekType
	{
		[XmlElement(ElementName = "SoortAanbod", Namespace = "http://schemas.datacontract.org/2004/07/Funda.Common.Library.Enumerations")]
		public string SoortAanbod { get; set; }
		[XmlAttribute(AttributeName = "a", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string A { get; set; }
	}

	[XmlRoot(ElementName = "Object", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Object
	{
		[XmlElement(ElementName = "AangebodenSindsTekst", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string AangebodenSindsTekst { get; set; }
		[XmlElement(ElementName = "AanmeldDatum", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string AanmeldDatum { get; set; }
		[XmlElement(ElementName = "AantalBeschikbaar", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public AantalBeschikbaar AantalBeschikbaar { get; set; }
		[XmlElement(ElementName = "AantalKamers", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string AantalKamers { get; set; }
		[XmlElement(ElementName = "AantalKavels", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public AantalKavels AantalKavels { get; set; }
		[XmlElement(ElementName = "Aanvaarding", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Aanvaarding { get; set; }
		[XmlElement(ElementName = "Adres", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Adres { get; set; }
		[XmlElement(ElementName = "Afstand", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Afstand { get; set; }
		[XmlElement(ElementName = "BronCode", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string BronCode { get; set; }		
		[XmlElement(ElementName = "DatumAanvaarding", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public DatumAanvaarding DatumAanvaarding { get; set; }
		[XmlElement(ElementName = "DatumOndertekeningAkte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public DatumOndertekeningAkte DatumOndertekeningAkte { get; set; }
		[XmlElement(ElementName = "Foto", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Foto { get; set; }
		[XmlElement(ElementName = "FotoLarge", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string FotoLarge { get; set; }
		[XmlElement(ElementName = "FotoLargest", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string FotoLargest { get; set; }
		[XmlElement(ElementName = "FotoMedium", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string FotoMedium { get; set; }
		[XmlElement(ElementName = "FotoSecure", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string FotoSecure { get; set; }
		[XmlElement(ElementName = "GewijzigdDatum", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public GewijzigdDatum GewijzigdDatum { get; set; }
		[XmlElement(ElementName = "GlobalId", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string GlobalId { get; set; }
		[XmlElement(ElementName = "GroupByObjectType", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string GroupByObjectType { get; set; }
		[XmlElement(ElementName = "Heeft360GradenFoto", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Heeft360GradenFoto { get; set; }
		[XmlElement(ElementName = "HeeftBrochure", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HeeftBrochure { get; set; }
		[XmlElement(ElementName = "HeeftOpenhuizenTopper", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HeeftOpenhuizenTopper { get; set; }
		[XmlElement(ElementName = "HeeftOverbruggingsgrarantie", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HeeftOverbruggingsgrarantie { get; set; }
		[XmlElement(ElementName = "HeeftPlattegrond", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HeeftPlattegrond { get; set; }
		[XmlElement(ElementName = "HeeftTophuis", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HeeftTophuis { get; set; }
		[XmlElement(ElementName = "HeeftVeiling", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HeeftVeiling { get; set; }
		[XmlElement(ElementName = "HeeftVideo", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HeeftVideo { get; set; }
		[XmlElement(ElementName = "HuurPrijsTot", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public HuurPrijsTot HuurPrijsTot { get; set; }
		[XmlElement(ElementName = "Huurprijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Huurprijs Huurprijs { get; set; }
		[XmlElement(ElementName = "HuurprijsFormaat", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public HuurprijsFormaat HuurprijsFormaat { get; set; }
		[XmlElement(ElementName = "Id", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Id { get; set; }
		[XmlElement(ElementName = "InUnitsVanaf", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public InUnitsVanaf InUnitsVanaf { get; set; }
		[XmlElement(ElementName = "IndProjectObjectType", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IndProjectObjectType { get; set; }
		[XmlElement(ElementName = "IndTransactieMakelaarTonen", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public IndTransactieMakelaarTonen IndTransactieMakelaarTonen { get; set; }
		[XmlElement(ElementName = "IsSearchable", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IsSearchable { get; set; }
		[XmlElement(ElementName = "IsVerhuurd", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IsVerhuurd { get; set; }
		[XmlElement(ElementName = "IsVerkocht", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IsVerkocht { get; set; }
		[XmlElement(ElementName = "IsVerkochtOfVerhuurd", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string IsVerkochtOfVerhuurd { get; set; }
		[XmlElement(ElementName = "Koopprijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Koopprijs { get; set; }
		[XmlElement(ElementName = "KoopprijsFormaat", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string KoopprijsFormaat { get; set; }
		[XmlElement(ElementName = "KoopprijsTot", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string KoopprijsTot { get; set; }
		[XmlElement(ElementName = "MakelaarId", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string MakelaarId { get; set; }
		[XmlElement(ElementName = "MakelaarNaam", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string MakelaarNaam { get; set; }
		[XmlElement(ElementName = "MobileURL", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string MobileURL { get; set; }
		[XmlElement(ElementName = "Note", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Note Note { get; set; }
		[XmlElement(ElementName = "OpenHuis", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public OpenHuis OpenHuis { get; set; }
		[XmlElement(ElementName = "Oppervlakte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Oppervlakte { get; set; }
		[XmlElement(ElementName = "Perceeloppervlakte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Perceeloppervlakte Perceeloppervlakte { get; set; }
		[XmlElement(ElementName = "Postcode", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Postcode { get; set; }
		[XmlElement(ElementName = "Prijs", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Prijs Prijs { get; set; }
		[XmlElement(ElementName = "PrijsGeformatteerdHtml", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string PrijsGeformatteerdHtml { get; set; }
		[XmlElement(ElementName = "PrijsGeformatteerdTextHuur", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string PrijsGeformatteerdTextHuur { get; set; }
		[XmlElement(ElementName = "PrijsGeformatteerdTextKoop", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string PrijsGeformatteerdTextKoop { get; set; }
		[XmlElement(ElementName = "Producten", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Producten Producten { get; set; }
		[XmlElement(ElementName = "Project", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Project Project { get; set; }
		[XmlElement(ElementName = "ProjectNaam", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public ProjectNaam ProjectNaam { get; set; }
		[XmlElement(ElementName = "PromoLabel", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public PromoLabel PromoLabel { get; set; }
		[XmlElement(ElementName = "PublicatieDatum", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string PublicatieDatum { get; set; }
		[XmlElement(ElementName = "PublicatieStatus", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string PublicatieStatus { get; set; }
		[XmlElement(ElementName = "SavedDate", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public SavedDate SavedDate { get; set; }
		[XmlElement(ElementName = "Soort-aanbod", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Soortaanbod { get; set; }
		[XmlElement(ElementName = "SoortAanbod", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string SoortAanbod { get; set; }
		[XmlElement(ElementName = "StartOplevering", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public StartOplevering StartOplevering { get; set; }
		[XmlElement(ElementName = "TimeAgoText", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public TimeAgoText TimeAgoText { get; set; }
		[XmlElement(ElementName = "TransactieAfmeldDatum", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public TransactieAfmeldDatum TransactieAfmeldDatum { get; set; }
		[XmlElement(ElementName = "TransactieMakelaarId", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public TransactieMakelaarId TransactieMakelaarId { get; set; }
		[XmlElement(ElementName = "TransactieMakelaarNaam", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public TransactieMakelaarNaam TransactieMakelaarNaam { get; set; }
		[XmlElement(ElementName = "TypeProject", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string TypeProject { get; set; }
		[XmlElement(ElementName = "URL", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string URL { get; set; }
		[XmlElement(ElementName = "VerkoopStatus", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string VerkoopStatus { get; set; }
		[XmlElement(ElementName = "WGS84_X", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string WGS84_X { get; set; }
		[XmlElement(ElementName = "WGS84_Y", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string WGS84_Y { get; set; }
		[XmlElement(ElementName = "WoonOppervlakteTot", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string WoonOppervlakteTot { get; set; }
		[XmlElement(ElementName = "Woonoppervlakte", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Woonoppervlakte { get; set; }
		[XmlElement(ElementName = "Woonplaats", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Woonplaats { get; set; }
		[XmlElement(ElementName = "ZoekType", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public ZoekType ZoekType { get; set; }
		[XmlElement(ElementName = "Land", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Land Land { get; set; }
		[XmlElement(ElementName = "ChildrenObjects", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public ChildrenObjects ChildrenObjects { get; set; }
	}

	[XmlRoot(ElementName = "Land", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Land
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "ChildrenObjects", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class ChildrenObjects
	{
		[XmlElement(ElementName = "Object", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Object Object { get; set; }
	}

	[XmlRoot(ElementName = "Objects", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Objects
	{
		[XmlElement(ElementName = "Object", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public List<Object> Object { get; set; }
	}

	[XmlRoot(ElementName = "VorigeUrl", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class VorigeUrl
	{
		[XmlAttribute(AttributeName = "nil", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName = "Paging", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class Paging
	{
		[XmlElement(ElementName = "AantalPaginas", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string AantalPaginas { get; set; }
		[XmlElement(ElementName = "HuidigePagina", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string HuidigePagina { get; set; }
		[XmlElement(ElementName = "VolgendeUrl", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string VolgendeUrl { get; set; }
		[XmlElement(ElementName = "VorigeUrl", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public VorigeUrl VorigeUrl { get; set; }
	}

	[XmlRoot(ElementName = "LocatieFeed", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
	public class LocatieFeed
	{
		[XmlElement(ElementName = "AccountStatus", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string AccountStatus { get; set; }
		[XmlElement(ElementName = "EmailNotConfirmed", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string EmailNotConfirmed { get; set; }
		[XmlElement(ElementName = "ValidationFailed", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string ValidationFailed { get; set; }
		[XmlElement(ElementName = "ValidationReport", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public ValidationReport ValidationReport { get; set; }
		[XmlElement(ElementName = "Website", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string Website { get; set; }
		[XmlElement(ElementName = "Metadata", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Metadata Metadata { get; set; }
		[XmlElement(ElementName = "Objects", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Objects Objects { get; set; }
		[XmlElement(ElementName = "Paging", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public Paging Paging { get; set; }
		[XmlElement(ElementName = "TotaalAantalObjecten", Namespace = "http://schemas.datacontract.org/2004/07/FundaAPI.Feeds.Entities")]
		public string TotaalAantalObjecten { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName = "i", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string I { get; set; }
	}

}
