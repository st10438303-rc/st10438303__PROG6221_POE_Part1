using System;
using System.Collections.Generic;

namespace CybersecurityChatbot
{
    class ResponseEngine
    {
        private Dictionary<string, string> responses;

        public ResponseEngine()
        {
            responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // Greeting responses
                { "how are you", "I'm functioning well, thank you for asking! Ready to help you with cybersecurity awareness!" },
                { "how are you doing", "Doing great! All systems operational. How can I assist you with online safety today?" },
                
                // Purpose responses
                { "what is your purpose", "My purpose is to educate and raise awareness about cybersecurity threats and best practices to keep you safe online!" },
                { "what can you do", "I can provide information about password safety, phishing prevention, safe browsing habits, and general cybersecurity tips!" },
                { "what can i ask you about", "You can ask me about:\n  • Password safety (e.g., 'How to create strong passwords?')\n  • Phishing (e.g., 'What is phishing?')\n  • Safe browsing (e.g., 'How to browse safely?')\n  • General security tips" },
                { "what can i ask", "Feel free to ask about password safety, phishing attacks, safe browsing, or general security tips!" },
                
                // Password safety responses
                { "password", "Strong passwords should be at least 12 characters long and include uppercase, lowercase, numbers, and symbols. Never reuse passwords across different sites!" },
                { "password safety", "Use a password manager, enable 2FA whenever possible, and avoid using personal information in your passwords!" },
                { "strong password", "Create strong passwords by using random words, numbers, and symbols. Example: 'PurpleTiger$42Coffee!'" },
                
                // Phishing responses
                { "phishing", "Phishing is a cyber attack where criminals impersonate legitimate organizations to steal sensitive information via email, text, or fake websites." },
                { "phishing email", "Never click suspicious links or download attachments from unknown senders. Always verify the sender's email address and look for red flags like urgent language or spelling errors." },
                
                // Safe browsing responses
                { "safe browsing", "Always look for 'https://' and the padlock icon in your browser's address bar. Avoid entering personal information on unsecured websites." },
                { "browsing safety", "Use ad-blockers, keep your browser updated, don't save passwords in your browser, and clear your cache regularly!" },
                
                // Help responses
                { "help", "I can help with cybersecurity topics! Try asking about passwords, phishing, safe browsing, or just say 'hi' to chat!" },
                { "hello", "Hello! Ready to learn about online safety? Ask me anything about cybersecurity!" },
                { "hi", "Hi there! I'm your cybersecurity assistant. What would you like to know about staying safe online?" },
                
                // Exit responses
                { "exit", "Goodbye! Stay safe online and remember to practice good cybersecurity habits! 🔒" },
                { "quit", "Goodbye! Stay safe online and remember to practice good cybersecurity habits! 🔒" },
                { "bye", "Goodbye! Stay safe online and remember to practice good cybersecurity habits! 🔒" }
            
    };
        }

        public string GetResponse(string input)
        {
            foreach (var key in responses.Keys)
            {
                if (input.ToLower().Contains(key.ToLower()))
                {
                    return responses[key];
                }
            }
            return null;
        }
    }
}