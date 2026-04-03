namespace DevQuestions.Presenters;

public record CreateQuestionRequest(string Title, string Text, Guid UserId, Guid[] TagIds);