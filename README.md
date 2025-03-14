# Xunit-Proto

Requirements:

Update DocFX: dotnet tool update -g docfx

Install dotnet-script: dotnet tool install -g dotnet-script

**Steps:**

1. Navigate to the Docs/ directory: cd Docs

2. Generate and serve documentation: docfx docfx.json --serve

3. Open the browser and navigate to http://localhost:8080 to view the documentation

4. To update class names: dotnet-script Preprocessor.csx
  *(This will generate new class names for partial Assert based on their file names)*

5. Regenerate and serve the documentation: docfx docfx.json --serve

6. Open your browser and go to http://localhost:8080: This will display the new classes.

**Note:**

There is no way to revert these changes unless you delete the v3-2.0.0 folder in v3.
To restore the original state, navigate to the v3 folder and run:
git clone --recurse-submodules https://github.com/xunit/xunit.git -b v3-2.0.0 v3-2.0.0