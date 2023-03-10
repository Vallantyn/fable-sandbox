// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

var path = require("path");

module.exports = {
    mode: "development",
    entry: "./build/App.js",
    output: {
        path: path.join(__dirname, "./public"),
        filename: "bundle.js",
    },
    devServer: {
        static: {
            directory: path.resolve(__dirname, "./public"),
            publicPath: "/",
        },
        port: 8080,
    },
    module: {
        rules: [
            {
                test: /\.(glsl|vert|frag)$/,
                exclude: /node_modules/,
                type: 'asset/source',
                use: [
                    {
                        loader: 'glslify-loader',
                        options: {
                            transform: [
                                ['glslify-import', {}]
                            ]
                        }
                    }
                ]
            }
        ]
    }
}
