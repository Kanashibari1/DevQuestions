namespace DevQuestion.Contracts;

public record GetQuestionsDto(string Search, Guid[] TagsIds, int Page, int PageSize);