// A '.tsx' file enables JSX support in the TypeScript compiler, 
// for more information see the following page on the TypeScript wiki:
// https://github.com/Microsoft/TypeScript/wiki/JSX

import * as React from "react";

import * as ReactDOM from "react-dom";

ReactDOM.render(
    <div>
        <h2>Test 123</h2>
    </div>,
    document.getElementById("foodorder")
);