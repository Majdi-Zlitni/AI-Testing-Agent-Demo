# AI Testing Agent Demo

A .NET-based demo that turns plain-English user stories (stored in a repo) into automated browser tests using an AI-driven two-stage strategy and Playwright. Built and demonstrated against https://www.saucedemo.com as an example target application.

This project showcases how to combine:
- Azure OpenAI (LLM) for reasoning and test-step generation
- RAG (Retrieval-Augmented Generation) for feeding repo context (user stories) to the model
- MCP (Model-Context-Protocol) as the pattern for the agent to produce actions which are executed by Playwright
- Resilient executor code patterns that correct for common AI mistakes

Purpose: a reproducible, educational demo for students and professionals to learn the foundations of autonomous test agents within the Microsoft ecosystem (Azure + .NET).

---

## Presentation materials (PDF)

A full speaker-ready PDF for the talk is included in this repository:

[![Presentation image](doc/FirstStepsTowardsBuildingAutonomousTestAgents.png)](doc/AI-DrivenTestingRevolutionFirstStepsTowardsBuildingAutonomousTestAgents.pdf)

---

## Quick start for presenters

1. Prepare environment:
   - .NET 8 SDK
   - Playwright (install browsers: `playwright install`)
   - Azure OpenAI access (endpoint + key + deployment name)  

2. Update configuration:
   - Set `appsettings.json` or environment variables:
     - AZURE_OPENAI_ENDPOINT, AZURE_OPENAI_DEPLOYMENT and connect to your microsoft account via visual studio
   - Ensure `GitHub:UserStoryPath` points to the user story you want to demo.

3. Run the demo:
   - `dotnet restore && dotnet build`
   - `dotnet run`
   - Watch the console for the two-stage planning output and Playwright browser execution.

4. Presentation flow (use the PDF; here's a short script):
   - Hook: "What if agents could do the testing for us?"
   - Demo #1: Happy path (end-to-end purchase)
   - Deep dive: Architecture (Eyes, Brain, Hands), LLM, RAG, MCP
   - Debugging story: key issues and resilient fixes
   - Q&A
