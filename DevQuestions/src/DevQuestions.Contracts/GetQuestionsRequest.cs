namespace DevQuestions.Presenters;

public record GetQuestionsRequest(string Search, Guid[] Tags, int Page, int PageSize);