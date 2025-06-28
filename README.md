## Disclaimer:
I am not associated with Rockwell in any way and all dlls/references in this repo are openly distributed by Rockwell and are easily downloaded from their site.

# Overview
The goal of this project is to programmically convert an ACD file for a Rockwell PLC to an L5X file so that it can be manipulated by third party software.

Right now the exe file is a simple command line utility that takes 2 parameters, the first is the path to an ACD file and the second is an output path for an L5X file that will be generated

## Instructions
Use the following command through cmd line after building the project:
```console
RSLogixACDToL5X.exe <ACD File Path> <L5X File Path>
```

## Depdendencies
Building this project requires .Net 4.8.
This utility requires the RSLogix version of whatever ACD file you are trying to convert to be installed on the machine.
