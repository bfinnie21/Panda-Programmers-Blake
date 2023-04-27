﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollaborationManager_BDD_Tests.PageObjects
{
    public class TopArtistPageObject : PageObject
    {
        public TopArtistPageObject(IWebDriver webDriver) : base(webDriver)
        {
            _pageName = "TopArtist";
        }

        public IWebElement TopArtistIndexButton => _webDriver.FindElement(By.Id("topArtistGen"));
        public IWebElement GenerateButton => _webDriver.FindElement(By.Id("artist-generate"));
        public IWebElement track => _webDriver.FindElement(By.Id("remove-entry-icon-19"));
        public IWebElement NavbarToggle => _webDriver.FindElement(By.Id("navbar-toggle-button"));
        public IWebElement SpotifyLogin => _webDriver.FindElement(By.Id("spotify-button"));


        public void GoToTopArtistGenerator()
        {
            TopArtistIndexButton.Click();
        }

        public void GeneratePlaylist()
        {
            GenerateButton.Click();
        }

        public void CheckLogin()
        {
            NavbarToggle.Click();
            SpotifyLogin.Click();
        }
    }
}
