---
applyTo: "**/*.cs"
---

# C# Development

## SOLID

Apply **SRP**, **OCP**, **LSP**, **ISP**, **DIP** throughout all code.

## .NET Practices

- Prefer `async`/`await` for I/O-bound operations.
- Use the DI container; depend on abstractions, not concretions.
- Consistent exception handling and logging strategy.
- Use modern C# features: records, pattern matching, primary constructors.

## Naming Conventions
- Never abbreviate type, method, or variable names (be descriptive).
- Replace all magic numbers/strings with named constants.
- Organize scripts/files into logical subfolders by feature/responsibility.
- Use **PascalCase** for types, methods, properties, and public members (e.g., `UiManager`, not `UI` or `uiManager`).
- Use **_camelCase** for private fields and local variables (with leading underscore).
- Prefix interfaces with `I` (e.g., `IUserService`, `IRepository`).

## Documentation & Comments
- Never add meta-comments (e.g., "moved from...", "refactored because...").
- Always provide XML doc comments for **public** types/members (include `<summary>`, `<param>`, `<returns>`, and `<example>`/` <code>` when useful).
- Comments only when intent is non-obvious; keep them concise (~100 chars wrapped).

## Formatting & Structure
- Strictly follow `.editorconfig` for formatting (line length, indentation, etc.).
- Prefer **file-scoped namespaces** and group `using` directives at file top (remove unused).
- Prefer **primary constructors** for simple classes/records.
- Always insert newline before opening `{` of blocks (if, for, while, foreach, using, try, etc.).
- Expand braces `{}` for all blocks except very short one-liners (single expression).
- Place final `return` on its own line.
- Prefer pattern matching, switch expressions, and records over older constructs.
- Use `nameof` for member names instead of magic strings.
- Prefer qualified names via `using` imports over fully qualified names.
- Use collection/object initializers for empty/new instances (`new() { }`, `[]`, `{}`).
- Explicitly mark `private` on fields/methods.
- Make private methods `static` when they have no instance access.

## Nullable Reference Types
- Declare variables non-nullable by default.
- Check for `null` only at true entry points (parameters, external data).
- Always use `is null` / `is not null` instead of `== null` / `!= null`.
- Trust compiler nullability annotations — do **not** add redundant null checks.

## Performance
- Measure before optimizing; avoid premature optimization.

## Hard Bans (**NEVER USE**)
- `var` keyword
- `#region` directives
- Godot signals (use direct method calls or events instead)
- Self-evident/redundant null checks
- Tuple literals `(x, y)` — create a dedicated class/struct/record
- Breaking API changes (unless explicitly requested)
