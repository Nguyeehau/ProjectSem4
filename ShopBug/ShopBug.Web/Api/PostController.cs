using ShopBug.Model.Models;
using ShopBug.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Service;

namespace ShopBug.Web.Api
{
    public class PostController : ApiControllerBase
    {
        IPostService _postService;
        public PostController(IErrorService errorService, IPostService postService) : base(errorService)
        {
            this._postService = postService;
        }
        // create methid getall enttiy Post;
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
           {
               HttpResponseMessage response = null;
               if (ModelState.IsValid)
               {
                   response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
               }
               else
               {
                   var listPost = _postService.GetAll();
                   response = request.CreateResponse(HttpStatusCode.OK, listPost);
               }
               return response;
           });
        }
        //Create method add Post;
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, Post post)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postNew = _postService.Add(post);
                    _postService.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.OK, postNew);
                }
                return response;
            });
        }
        //create method update post
        public HttpResponseMessage Put(HttpRequestMessage request, Post post)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postService.Update(post);
                    _postService.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        //Create mothod Delete post
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
           {
               HttpResponseMessage response = null;
               if (ModelState.IsValid)
               {
                   response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
               }
               else
               {
                   _postService.Delete(id);
                   _postService.SaveChanges();
                   response = request.CreateResponse(HttpStatusCode.OK);
               }
               return response;
           });

        }
    }
}
