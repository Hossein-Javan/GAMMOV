namespace GAMMOV.CoreLayer.DTOs.Comment;

public class CreateCommentDto
{
    public int PostId { get; set; }
    public string FullName { get; set; }
    public string Description { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
}