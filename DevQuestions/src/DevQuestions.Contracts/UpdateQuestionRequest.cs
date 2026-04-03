namespace DevQuestions.Presenters;

public record UpdateQuestionRequest(string Title, string Text, Guid[] TagIds);