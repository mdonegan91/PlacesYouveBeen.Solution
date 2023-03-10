using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesYouveBeen.Models;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlacesTests : IDisposable
  {
    public void Dispose()
    {
      Destination.ClearAll();
    }

    [TestMethod]
    public void PlacesConstructor_CreatesInstanceOfPlaces_Places()
    {
      Destination newPlaces = new Destination("test", "test", "test");
      Assert.AreEqual(typeof(Destination), newPlaces.GetType());
    }

    [TestMethod]
    public void GetAndSetCityName_ReturnsCityName_String()
    {
      string city = "Paris, Texas";
      string image = "image";
      string journal = "here's my journal";
      Destination newDestination = new Destination(city, image, journal);
      string result = newDestination.CityName;
      Assert.AreEqual(city, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_DestinationList()
    {
      List<Destination> newList = new List<Destination> { };
      List<Destination> result = Destination.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsDestinationList_DestinationList()
    {
      string city1 = "Paris, Texas";
      string city2 = "Paris, France";
      string image1 = "image";
      string image2 = "second image";
      string journal1 = "here's my journal";
      string journal2 = "here's my second journal";
      Destination newDestination1 = new Destination(city1, image1, journal1);
      Destination newDestination2 = new Destination(city2, image2, journal2);
      List<Destination> newList = new List<Destination> { newDestination1, newDestination2 };
      List<Destination> result = Destination.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_DestinationInstantiateWithAnIdAndGetterReturns_Int()
    {
      string city = "Paris, Texas";
      string image = "image";
      string journal = "here's my journal";
      Destination newDestination = new Destination(city, image, journal);
      int result = newDestination.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectDestination_Destination()
    {
      string city1 = "Paris, Texas";
      string city2 = "Paris, France";
      string image1 = "image";
      string image2 = "second image";
      string journal1 = "here's my journal";
      string journal2 = "here's my second journal";
      Destination newDestination1 = new Destination(city1, image1, journal1);
      Destination newDestination2 = new Destination(city2, image2, journal2);
      Destination result = Destination.Find(2);
      Assert.AreEqual(newDestination2, result);
    }
  }
}