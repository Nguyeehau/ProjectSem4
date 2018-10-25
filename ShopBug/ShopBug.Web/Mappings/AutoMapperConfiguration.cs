using AutoMapper;
using ShopBug.Model.Models;
using ShopBug.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopBug.Web.Mappings
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<PostTag, PostTagViewModel>();
            CreateMap<ProductCategory, ProductViewModel>();
            CreateMap<Product, ProductViewModel>();


        }
    }
}