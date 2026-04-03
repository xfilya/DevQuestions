using DevQuestions.Domain.Questions;
using Microsoft.AspNetCore.Mvc;

namespace DevQuestions.Presenters;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateQuestionRequest createQuestionRequest,
        CancellationToken ct = default)
    {
        return Ok("Question created!");
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetQuestionsRequest getQuestionsRequest,
        CancellationToken ct = default)
    {
        return Ok("Questions loaded!");
    }

    [HttpGet("{questionId:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid questionId,
        CancellationToken ct = default)
    {
        return Ok("Question loaded!");
    }

    [HttpPut("{questionId:guid}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid questionId,
        [FromBody] UpdateQuestionRequest updateQuestionRequest,
        CancellationToken ct = default)
    {
        return Ok("Question updated!");
    }

    [HttpDelete("{questionId:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid questionId,
        CancellationToken ct = default)
    {
        return Ok("Question deleted!");
    }

    [HttpPut("{questionId:guid}/solution")]
    public async Task<IActionResult> SetSolution(
        [FromRoute] Guid questionId,
        [FromQuery] Guid answerId,
        CancellationToken ct = default)
    {
        return Ok("Question solution updated!");
    }
    
    [HttpPost("{questionId:guid}/answers")]
    public async Task<IActionResult> AddAnswer(
        [FromRoute] Guid questionId, 
        [FromBody] AddAnswerRequest addAnswerRequest,
        CancellationToken ct = default)
    {
        return Ok("Answer added!");
    }

    
    
}