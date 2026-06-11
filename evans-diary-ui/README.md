Recommended deployment flow:

1. Run static build locally `npm run build:static`.
2. Test website with `npm run preview`.
3. Upload dist output to hosting root.
4. Add web.config to root directory.
5. Test direct URL refresh on deep links (for example /family).
6. Verify static JSON path loads correctly.
