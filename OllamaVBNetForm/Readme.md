**Notes:**
- I setup my environment with Windows based Ollama
- My "PATH" environment variable must include path to Ollama:
    C:\Users\tidre\AppData\Local\Programs\Ollama
- Assuming that your Ollama server is running.
- Load the project in Visual Studio 2022 and run. I didn't include binaries for obvious reasons. The labels inside the app are self-explanatory...

****Project has two Forms:****

**Calling Ollama as Web EndPoint:**
    
This is recommended approach as you can later point it to any provider and it would work just fine.

**Calling Ollama Directly** (Alternative Approach in the attached program):

This works fine for your need however, it is more tightly coupled approach and hence there's lack of extensibility so generally it is not recommend.

- Both approaches can use streams (for word by word output) or buffered response.
- It also demonstrates JSON response output that is used when dealing with these models programmatically.
