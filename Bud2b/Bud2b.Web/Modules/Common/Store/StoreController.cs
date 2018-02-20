using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bud2b.Modules.Common.Profile
{
    using Bud2b.Modules.Common.Instagram;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using System;
    using System.IO;
    using System.Net;
    using System.Runtime.Serialization.Json;
    using System.Text;

    [RoutePrefix("Store"), Route("{action=index}")]
    public class StoreController : Controller
    {

        public async new Task<ActionResult> Store()
        {
            //var oAuthResponse = Session["InstaSharp.AuthInfo"] as OAuthResponse;
            //var userResponse = Session["InstaSharp.UserInfo"] as UserResponse;
            //var mediaResponse = Session["InstaSharp.Media"] as MediasResponse;

            //if (oAuthResponse == null)
            //{
            //    return RedirectToAction("Login");
            //}

            //if (userResponse == null)
            //{
            //    userResponse = await GetUserInfo(oAuthResponse);
            //    mediaResponse = Session["InstaSharp.Media"] as MediasResponse;
            //}

            //ViewData["Media"] = mediaResponse.Data;
            var url = string.Format("https://www.instagram.com/_chalicefarms/media/");

            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

            // Create the Json serializer and parse the response
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Instagram.RootObject));
            Instagram.RootObject instagramData = null;
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                // deserialize the JSON object using the WeatherData type.
                instagramData = (Instagram.RootObject)serializer.ReadObject(ms);
            }

            return View(MVC.Views.Common.Store.StorePage, instagramData);//, userResponse.Data);
        }

        static void asyncClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            // Create the Json serializer and parse the response
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Instagram.RootObject));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(e.Result)))
            {
                // deserialize the JSON object using the WeatherData type.
                var instagramData = (Instagram.RootObject)serializer.ReadObject(ms);
            }
        }

        //private async Task<UserResponse> GetUserInfo(OAuthResponse oAuthResponse)
        //{
        //    Users users = new Users(config, oAuthResponse);
        //    UserResponse user = await users.GetSelf();
        //    MediasResponse media = await users.Recent(oAuthResponse.User.Id, "100", "", 100, null, null);

        //    Session.Add("InstaSharp.UserInfo", user);
        //    Session.Add("InstaSharp.Media", media);

        //    return user;
        //}

        //public ActionResult Login()
        //{
        //    var scopes = new List<OAuth.Scope>();
        //    scopes.Add(InstaSharp.OAuth.Scope.Basic);
        //    scopes.Add(InstaSharp.OAuth.Scope.Public_Content);
        //    scopes.Add(InstaSharp.OAuth.Scope.Follower_List);
        //    scopes.Add(InstaSharp.OAuth.Scope.Comments);
        //    scopes.Add(InstaSharp.OAuth.Scope.Relationships);
        //    scopes.Add(InstaSharp.OAuth.Scope.Likes);

        //    var link = InstaSharp.OAuth.AuthLink(config.OAuthUri + "authorize", config.ClientId, config.RedirectUri, scopes, InstaSharp.OAuth.ResponseType.Code);

        //    return Redirect(link);
        //}

        //public async Task<ActionResult> OAuth(string code)
        //{
        //    // add this code to the auth object
        //    var auth = new OAuth(config);

        //    // now we have to call back to instagram and include the code they gave us
        //    // along with our client secret
        //    var oauthResponse = await auth.RequestToken(code);

        //    // both the client secret and the token are considered sensitive data, so we won't be
        //    // sending them back to the browser. we'll only store them temporarily.  If a user's session times
        //    // out, they will have to click on the authenticate button again - sorry bout yer luck.
        //    Session.Add("InstaSharp.AuthInfo", oauthResponse);

        //    // all done, lets redirect to the home controller which will send some intial data to the app
        //    return RedirectToAction("Profile");
        //}

    }
}