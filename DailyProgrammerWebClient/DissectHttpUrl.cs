using System;
using System.Text;

namespace DailyProgrammerWebClient
{
    public class DissectHttpUrl : IDissectedUrl
    {
        // ex: http://httpbin.org/

        // fields
        private string _url;
        private string _protocol = "http://";
        private string _urlWithoutProtocol;    // httpbin.org/
        private string _server;
        private string _tld;
        private string _page;

        // props
        public string Server
        {
            get { return _server; }
        }
        public string TLD
        {
            get { return _tld; }
        }
        public string Protocol
        {
            get {return _protocol; }
        }
        public string Page
        {
            get { return _page; }
        }
        
        //ctor
        public DissectHttpUrl(string url)
        {
            if (url != null)
            {
                _url = url;
            }
            else
            {
                throw new ArgumentNullException("url");
            }
        }

        // public methods
        public void Dissect()
        {
            RemoveProtocol();
            ExtractPage();
            ExtractServerAndTld();
        }

        // private methods
        private void TrimTld()
        {
            int slashIndex = _tld.IndexOf('/');
            _tld = _tld.Remove(slashIndex, _tld.Length - slashIndex);
        }
        private void ExtractPage()
        {
            int indexOfFirstForwardSlash = _urlWithoutProtocol.IndexOf('/');
            _page = _urlWithoutProtocol.Substring(indexOfFirstForwardSlash);
        }
        private void ExtractServerAndTld()
        {
            // TODO account for subdomains
            string[] splitUrl = _urlWithoutProtocol.Split('.');
            if (splitUrl.Length == 2)    // only a server and tld, no subdomains
            {
                _server = splitUrl[0];
                _tld = splitUrl[1];
                TrimTld();
            }
        }
        private void RemoveProtocol()
        {
            var sb = new StringBuilder(_url);
            sb.Remove(0, 7);
            _urlWithoutProtocol = sb.ToString();
        }
    }
}
