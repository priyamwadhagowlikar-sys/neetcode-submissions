public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        int i=0;
        while(i < tokens.Length){
            if(tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
            {System.Console.WriteLine("top_element");
                int top_element = stack.Pop();
                int second_top = stack.Pop();
                switch(tokens[i])
                {
                    case "+":
                        stack.Push(second_top + top_element);
                        break;
                    case "-":
                        stack.Push(second_top - top_element);
                        break;
                    case "*":
                        stack.Push(second_top * top_element);
                        break;
                    case "/":
                        stack.Push(second_top / top_element);
                        break;
                }
            }
            else {
                stack.Push(int.Parse(tokens[i]));
            }
            i++;
        }
        return stack.Pop();
    }
}