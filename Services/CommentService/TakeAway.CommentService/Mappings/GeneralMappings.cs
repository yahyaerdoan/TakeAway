using AutoMapper;
using TakeAway.CommentService.DataAccessLayer.Entities;
using TakeAway.CommentService.Dtos;

namespace TakeAway.CommentService.Mappings;

public class GeneralMappings : Profile
{
    public GeneralMappings()
    {
        CreateMap<Comment, CreateCommentDto>().ReverseMap();
        CreateMap<Comment, UpdateCommentDto>().ReverseMap();
        CreateMap<Comment, GetByIdCommentDto>().ReverseMap();
        CreateMap<Comment, ResultCommentDto>().ReverseMap();
    }
}
