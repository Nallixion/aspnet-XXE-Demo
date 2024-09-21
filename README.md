# aspnet-XXE-Demo
Small demo to show Exploiting XML External Entities to fully understand the concepts in https://tryhackme.com/r/room/xxeinjection

https://dotnetcoretutorials.com/testing-xxe-vulnerabilities-in-net-core/?utm_content=cmp-true

https://book.hacktricks.xyz/pentesting-web/xxe-xee-xml-external-entity

https://github.com/swisskyrepo/PayloadsAllTheThings/blob/master/XXE%20Injection/README.md#classic-xxe

## Bing Chat
In .NET 8, the default settings for XML parsers have been improved to mitigate XXE vulnerabilities by disabling DTD processing by default. This means that even if you explicitly set `DtdProcessing` to `Parse`, the parser might still be configured to prevent external entity resolution for security reasons.

Here's a possible explanation for why `<name>&xxe;</name>` is always empty:

1. **Default Security Settings**: .NET 8 likely has enhanced security settings that prevent the resolution of external entities, even if DTD processing is enabled.
2. **Parser Configuration**: The XML parser might be configured to ignore or sanitize external entities to protect against XXE attacks.

To verify this, you can check the configuration of your XML parser and ensure that no additional security settings are overriding your `DtdProcessing` configuration.

If you need to test XXE vulnerabilities for educational purposes, consider using an older version of .NET or a controlled environment where you can safely enable and test these features. However, always ensure that such configurations are not used in production environments to avoid security risks.

If you have any more questions or need further assistance, feel free to ask!

Source: Conversation with Copilot, 20/09/2024
(1) XML External Entity Prevention Cheat Sheet - OWASP. https://cheatsheetseries.owasp.org/cheatsheets/XML_External_Entity_Prevention_Cheat_Sheet.html.
(2) Vulnerabilities due to XML files processing: XXE in C# ... - Habr. https://habr.com/en/companies/pvs-studio/articles/650933/.
(3) How to Identify & Avoid XXE Vulnerabilities in .Net - Site24x7. https://www.site24x7.com/learn/xxe-vulnerabilities.html.
(4) undefined. http://apache.org/xml/features/disallow-doctype-decl.
(5) Testing XXE Vulnerabilities In .NET Core – .NET Core Tutorials. https://dotnetcoretutorials.com/testing-xxe-vulnerabilities-in-net-core/.
(6) Vulnerabilities due to XML files processing: XXE in C# applications in .... https://pvs-studio.com/en/blog/posts/csharp/0918/.
(7) XXE Prevention: XML External Entity (XXE) Attacks and How to Avoid Them. https://bing.com/search?q=is+asp.net+core+vulnerable+to+xxe.
(8) XXE Prevention: XML External Entity (XXE) Attacks and How to Avoid Them. https://brightsec.com/blog/xxe-prevention/.
(9) How to Identify and Mitigate XXE Vulnerability? | Indusface Blog. https://www.indusface.com/blog/how-to-identify-and-mitigate-xxe-vulnerability/.
(10) Exploiting XXE Vulnerabilities in IIS/.NET - SANS Institute. https://www.sans.org/blog/exploiting-xxe-vulnerabilities-in-iis-net/.
(11) DotNet Security Cheat Sheet - OWASP. https://cheatsheetseries.owasp.org/cheatsheets/DotNet_Security_Cheat_Sheet.html.
(12) Vulnerabilities due to XML files processing: XXE in C# applications in .... https://dev.to/_sergvasiliev_/vulnerabilities-due-to-xml-files-processing-xxe-in-c-applications-in-theory-and-in-practice-3a67.
(13) .NET Core September 2020 Updates – 2.1.22 and 3.1.8. https://devblogs.microsoft.com/dotnet/net-core-september-2020/.
(14) undefined. https://test.com/target.txt.