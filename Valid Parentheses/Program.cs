// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IsValid("()[]{}");
bool IsValid(string s)
{
    if(s.Length%2!=0)
    {
        return false;
    }
    if (s[0] == ')' || s[0]==']'|| s[0]=='}')
    {
        return false;
    }
    Stack<char> full = new Stack<char>();
    var tmp =new char();
    for (int i = 0; i < s.Length; i++)
    {

        switch (s[i])
        {
            case '(':
                full.Push(s[i]);
                break;
            case ')':
                if (full.Count == 0)
                {
                    return false;
                }
                else
                {
                    tmp=full.Pop();
                    if(tmp=='{'||tmp=='[')
                    {
                        return false;
                    }
                }
                break;
            case '[':
                full.Push(s[i]);
                break;
            case ']':
                if (full.Count == 0)
                {
                    return false;
                }
                else
                {
                    tmp = full.Pop();
                    if (tmp == '{' || tmp == '(')
                    {
                        return false;
                    }
                }
                break;

            case '{':
                full.Push(s[i]);
                break;

            case '}':
                if (full.Count == 0)
                {
                    return false;
                }
                else
                {
                    tmp = full.Pop();
                    if (tmp == '[' || tmp == '(')
                    {
                        return false;
                    }
                }
                break;

        }
    }
    if(full.Count != 0)
    {
        return false;
    }
    return true;
}
