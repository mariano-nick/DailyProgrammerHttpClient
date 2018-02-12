using System;

namespace DailyProgrammerWebClient
{
    public class FetchHttpContentGet
    {
        //GET /docs/index.html HTTP/1.1
        //Host: www.nowhere123.com
        //Accept: image/gif, image/jpeg, */*
        //Accept-Language: en-us
        //Accept-Encoding: gzip, deflate
        //User-Agent: Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)
        //(blank line)

        private string _getLine;
        private IDissectedUrl _dissectedUrl;

        public FetchHttpContentGet(IDissectedUrl dissectedUrl)
        {
            if (dissectedUrl != null)
            {
                _dissectedUrl = dissectedUrl;
                ParseDissectedUrl();
            }
            else
            {
                throw new ArgumentNullException("dissectedUrl");
            }
        }

        private void ParseDissectedUrl()
        {
            _getLine = "GET " + _dissectedUrl.Page + " HTTP/1.1";
        }

        public void Fetch()
        {

        }
    }
}
