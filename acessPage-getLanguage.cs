using Envvio.Beggest.Api.Attributes;
using Envvio.Beggest.Core.Repositories;
using Envvio.Beggest.Core.Users;

using Microsoft.AspNet.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Envvio.Beggest.Api.Controllers
{
    public abstract class BaseApiController : ApiController
    {

        private readonly List<string> _supportedLanguages = Enum.GetValues( typeof( LanguageType ) ).Cast<LanguageType>().Select( l => l.GetCode() ).ToList();


        public BaseApiController( IUserRepository userRepository )
        {
            this.UserRepository = userRepository;
        }

        public IUserRepository UserRepository { get; }

        protected User CurrentUser()
        {
            if( !this.User.Identity.IsAuthenticated )
                return null;

            var user = this.UserRepository.Get( new Guid( this.User.Identity.GetUserId() ) );
            return user;
        }

        protected string CurrentLanguage()
        {
            if( this.CurrentUser() != null )
                return this.CurrentUser().Language.GetCode();

            var defaultLanguage = "en-US";

            if( this.Request.Headers.AcceptLanguage.Count > 0 )
            {

                var headerLang = this.Request.Headers.AcceptLanguage.FirstOrDefault( l => this._supportedLanguages.Contains( l.Value ) );

                return ( headerLang != null ) ? headerLang.Value : defaultLanguage;

            }

            return defaultLanguage;
        }

    }
}

