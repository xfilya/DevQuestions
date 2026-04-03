namespace DevQuestions.Presenters;

public record AddAnswerRequest(Guid UserId, string Text);