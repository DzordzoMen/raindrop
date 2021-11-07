#!/usr/bin/env sh
# abort on errors
set -e
# build
cd web/raindrop-web && npm run build
# add dist to commit and push it to gh-pages branch
git add web/raindrop-web/dist
git commit -m 'updating dist subtree'
git subtree push --prefix web/raindrop-web/dist origin gh-pages
