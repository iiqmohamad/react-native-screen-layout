
# react-native-screen-layout

## Getting started

`$ npm install react-native-screen-layout --save`

### Mostly automatic installation

`$ react-native link react-native-screen-layout`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-screen-layout` and add `RNScreenLayout.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNScreenLayout.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNScreenLayoutPackage;` to the imports at the top of the file
  - Add `new RNScreenLayoutPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-screen-layout'
  	project(':react-native-screen-layout').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-screen-layout/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-screen-layout')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNScreenLayout.sln` in `node_modules/react-native-screen-layout/windows/RNScreenLayout.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Screen.Layout.RNScreenLayout;` to the usings at the top of the file
  - Add `new RNScreenLayoutPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNScreenLayout from 'react-native-screen-layout';

// TODO: What to do with the module?
RNScreenLayout;
```
  