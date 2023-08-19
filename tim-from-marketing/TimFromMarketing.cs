using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        department = (department ?? "OWNER").ToUpper();
        return (id == null) ? $"{name} - {department}" : $"[{id}] - {name} - {department}";
    }
}
