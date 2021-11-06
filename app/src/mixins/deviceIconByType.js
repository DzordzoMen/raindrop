export default {
  methods: {
    deviceIconByType(type) {
      let icon = 'mdi-washing-machine';
      switch (type) {
        case 'washing-machine':
          icon = 'mdi-washing-machine';
          break;
        case 'sprinkler':
          icon = 'mdi-sprinkler-variant';
          break;
        case 'dishwasher':
          icon = 'mdi-dishwasher';
          break;
        case 'solar-panel':
          icon = 'mdi-solar-panel-large';
          break;
        default:
          break;
      }
      return icon;
    },
  },
};
