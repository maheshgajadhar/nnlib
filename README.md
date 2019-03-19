
# react-native-nnlib

## Getting started

`$ npm install react-native-nnlib --save`

### Mostly automatic installation

`$ react-native link react-native-nnlib`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-nnlib` and add `RNNnlib.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNNnlib.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNNnlibPackage;` to the imports at the top of the file
  - Add `new RNNnlibPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-nnlib'
  	project(':react-native-nnlib').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-nnlib/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-nnlib')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNNnlib.sln` in `node_modules/react-native-nnlib/windows/RNNnlib.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Nnlib.RNNnlib;` to the usings at the top of the file
  - Add `new RNNnlibPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNNnlib from 'react-native-nnlib';

// TODO: What to do with the module?
RNNnlib;
```
  